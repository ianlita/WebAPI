using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Post>> GetPosts()
        {
            return new List<Post>
            {
                new Post { Id = 1, UserId = 1, Title = "Post 1", Body = "This is the body of post 1" },
                new Post { Id = 2, UserId = 2, Title = "Post 2", Body = "This is the body of post 2" },
                new Post { Id = 3, UserId = 3, Title = "Post 3", Body = "This is the body of post 3" }
            };

        }
    }
}