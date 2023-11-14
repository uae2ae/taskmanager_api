using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using taskmanager_api.Services.TaskService;

namespace taskmanager_api.Services.TaskService
{
    public class TaskService : ITaskService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private User GetUser() => _context.Users.FirstOrDefault(u => u.Id == GetUserId())!;
        private Post GetPost() => _context.Posts.FirstOrDefault(p => p.Id == GetPostId())!;
        private int GetUserId() => int.Parse(_httpContextAccessor.HttpContext!.User.FindFirstValue(ClaimTypes.NameIdentifier)!);
        private int GetPostId() => int.Parse(_httpContextAccessor.HttpContext!.Request.RouteValues.SingleOrDefault(x => x.Key == "postId").Value?.ToString()!);
        
        public TaskService(IMapper mapper, DataContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }


    }
}