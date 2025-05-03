using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Services
{
    public interface IPostService
    {
        Task CratePost(Post item);
        Task<Post?> UpdatePost(int id, Post item);  
        Task<Post?> GetPost(int id);
        Task<List<Post>> GetAllPosts();
        Task DeletePost(int id);
    }
}