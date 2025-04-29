using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class PostService
    {
        private static readonly List<Post> AllPosts = new List<Post> {
            new Post { Id = 1, UserId = 1, Title = "Post 1", Body = "This is the body of post 1" },
            new Post { Id = 2, UserId = 2, Title = "Post 2", Body = "This is the body of post 2" },
            new Post { Id = 3, UserId = 3, Title = "Post 3", Body = "This is the body of post 3" }
        };

        public Task CreatePost(Post item)
        {
            AllPosts.Add(item);
            return Task.CompletedTask;
        }

        public Task<Post?> UpdatePost(int id, Post item)
        {
            var post = AllPosts.FirstOrDefault(p => p.Id == id);

            if(post != null) 
            {
                post.UserId = item.UserId;
                post.Title = item.Title;
                post.Body = item.Body;
            }

            return Task.FromResult(post);
        
        }

        public Task<Post?> GetPost(int id)
        {
            return Task.FromResult(AllPosts.FirstOrDefault(p => p.Id == id));   

        }

        public Task<List<Post>> GetAllPosts()
        {
            return Task.FromResult(AllPosts);
        }

        public Task DeletePost(int id)
        {
            var post = AllPosts.FirstOrDefault(p => p.Id == id);

            if(post != null) 
            {
                AllPosts.Remove(post);
            }
            return Task.CompletedTask;
        }
    }
}