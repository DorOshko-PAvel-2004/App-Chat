﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Database;
using SocialNetwork.Models;
using SocialNetwork.Services.Constants;
using SocialNetwork.Services.DTOs;
using SocialNetwork.Services.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.Services.Services
{
    public class PostService : IPostService
    {
        private readonly SocialNetworkDBContext context;
        private readonly IBlobService blobService;
        private readonly IMapper mapper;

        public PostService(SocialNetworkDBContext context, IBlobService blobService, IMapper mapper)
        {
            this.context = context;
            this.blobService = blobService;
            this.mapper = mapper;
        }

        public async Task<PostDTO> CreateAsync(PostDTO postDTO, IFormFile file = null, PhotoDTO photoDTO = null, VideoDTO videoDTO = null)
        {
            if (postDTO == null)
            {
                throw new ArgumentNullException(ExceptionMessages.InvalidModel);
            }

            // Create the post
            var user = await this.context.Users
               .FirstOrDefaultAsync(u => u.Id == postDTO.UserId)
               ?? throw new ArgumentException(ExceptionMessages.EntityNotFound);

            var post = this.mapper.Map<Post>(postDTO);

            post.UserId = postDTO.UserId;
            post.User = user;

            await this.context.Posts.AddAsync(post);
            await this.context.SaveChangesAsync();

            // Create the media
            await this.AddMediaToPost(file, photoDTO, videoDTO, post);

            // Save the changes
            await this.context.SaveChangesAsync();

            return this.mapper.Map<PostDTO>(post);
        }

        public async Task<bool> DeletePostAsync(int id)
        {
            try
            {
                var post = await this.context.Posts
                               .FirstOrDefaultAsync(p => p.Id == id);

                post.IsDeleted = true;
                post.DeletedOn = DateTime.UtcNow;
                await this.context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<PostDTO> GetPostByIdAsync(int id)
        {
            var post = await this.context.Posts.Where(p => !p.IsDeleted && p.Id == id)
                .ProjectTo<PostDTO>(mapper.ConfigurationProvider)
                .FirstOrDefaultAsync()
                ?? throw new ArgumentException(ExceptionMessages.EntityNotFound);

            return this.mapper.Map<PostDTO>(post);
        }

        public async Task<IEnumerable<PostDTO>> GetUserFriendsPostsAsync(Guid userId)
        {
            var friendships = await this.context.Friends
                .Where(f => f.UserId == userId && !f.IsDeleted)
                .ToListAsync();

            var friendsPosts = new List<PostDTO>();

            foreach (var fs in friendships)
            {
                var currFriendsPosts = await this.context.Posts
                    .Where(p => !p.IsDeleted && p.UserId == fs.UserFriendId)
                    .ProjectTo<PostDTO>(mapper.ConfigurationProvider)
                    .ToListAsync();

                friendsPosts.AddRange(currFriendsPosts);
            }

            return friendsPosts;
        }

        public async Task<IEnumerable<PostDTO>> GetUserPostsAsync(Guid userId)
        {
            var posts = await this.context.Posts
                .Where(p => !p.IsDeleted && p.UserId == userId)
                .ProjectTo<PostDTO>(mapper.ConfigurationProvider)
                .ToListAsync();

            if (!posts.Any())
            {
                throw new ArgumentException(ExceptionMessages.EntitiesNotFound);
            }

            return posts;
        }

        public async Task<IEnumerable<PostDTO>> GetByContentAsync(string searchCriteria = "", string sortOrder = "mostRecent")
        {
            if (string.IsNullOrWhiteSpace(searchCriteria))
            {
                throw new ArgumentException(ExceptionMessages.InvalidCriteria);
            }

            var result = await this.context.Posts
                            .Where(p => !p.IsDeleted && p.Content.Contains(searchCriteria))
                            .ProjectTo<PostDTO>(this.mapper.ConfigurationProvider)
                            .ToListAsync()
                        ?? throw new ArgumentException(ExceptionMessages.EntitiesNotFound);

            if (sortOrder == "nameAsc")
            {
                return result.OrderBy(p => p.Content);
            }
            else if (sortOrder == "nameDesc")
            {
                return result.OrderByDescending(p => p.Content);
            }
            return result.OrderByDescending(p => p.CreatedOn);
        }

        public async Task<PostDTO> EditPostAsync(PostDTO postDTO)
        {
            var postModel = await this.context.Posts
                .Include(p => p.Photo)
                .Include(p => p.Video)
                .FirstOrDefaultAsync(p => p.Id == postDTO.Id && !p.IsDeleted);

            if (postModel == null)
            {
                throw new ArgumentException(ExceptionMessages.EntityNotFound);
            }

            postModel.Content = postDTO.Content;
            postModel.Visibility = postDTO.Visibility;
            postModel.ModifiedOn = DateTime.UtcNow;

            await this.context.SaveChangesAsync();
            return this.mapper.Map<PostDTO>(postModel);
        }

        public async Task<IEnumerable<PostDTO>> GetAllAsync()
        {
            return await this.context.Posts.Where(p => !p.IsDeleted)
                             .ProjectTo<PostDTO>(this.mapper.ConfigurationProvider)
                             .ToListAsync();
        }

        public async Task<PostDTO> ChangeDisplayPicture(IFormFile file, Guid userId, string photoType)
        {
            var user = await this.context.Users
               .FirstOrDefaultAsync(u => u.Id == userId)
               ?? throw new ArgumentException(ExceptionMessages.EntityNotFound);

            var url = await this.blobService.UploadToBlobStorageAsync(file);

            var postDTO = new PostDTO { UserId = user.Id, PhotoUrl = url };

            var post = await this.CreateAsync(postDTO, file);

            if (photoType == "profile")
            {
                user.ProfilePictureUrl = url;
            }
            else if (photoType == "cover")
            {
                user.CoverPictureUrl = url;
            }
            await this.context.SaveChangesAsync();

            return postDTO;
        }

        private async Task<string> AddMediaToPost(IFormFile file, PhotoDTO photoDTO, VideoDTO videoDTO, Post post)
        {
            if (file != null)
            {
                var url = await this.blobService.UploadToBlobStorageAsync(file);
                photoDTO = new PhotoDTO { Url = url };

                var photo = this.mapper.Map<Photo>(photoDTO);
                photo.PostId = post.Id;

                post.Photo = photo;
                post.Video = null;

                return url;
            }
            else if (photoDTO != null)
            {
                var photo = this.mapper.Map<Photo>(photoDTO);
                photo.PostId = post.Id;

                post.Photo = photo;
                post.Video = null;

                return photo.Url;
            }
            else if (videoDTO != null)
            {
                var video = this.mapper.Map<Video>(videoDTO);
                video.PostId = post.Id;

                post.Video = video;
                post.Photo = null;

                return video.Url;
            }
            else
            {
                post.Photo = null;
                post.Video = null;

                return default;
            }
        }
    }
}