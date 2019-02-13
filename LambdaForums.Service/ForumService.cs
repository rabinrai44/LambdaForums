using LambdaForums.Data;
using LambdaForums.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LambdaForums.Service
{
    public class ForumService : IForum
    {
        private readonly ApplicationDbContext _context;

        public ForumService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task Create(Forum forum)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int forumId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Forum> GetAll()
        {
            return _context.Forums
                .Include(forum => forum.Posts);
        }

        public IEnumerable<ApplicationUser> GetAllActiveUsers()
        {
            throw new NotImplementedException();
        }

        public Forum GetById(int id)
        {
            var forum = _context.Forums.Where(f => f.Id == id) // looking in a forum corresponding forum primary key (id)
                .Include(f => f.Posts).ThenInclude(p => p.User) // making sure include the Posts property then include the User
                .Include(f => f.Posts).ThenInclude(p => p.Replies).ThenInclude(r => r.User) // include the Posts then Replies of the posts and the user who may the reply
                .FirstOrDefault(); // make sure the return the single instance rather than collection of forum

            return forum;
        }

        public Task updateForumDescription(int forumId, string newDescription)
        {
            throw new NotImplementedException();
        }

        public Task UpdateForumTitle(int forumId, string newTitle)
        {
            throw new NotImplementedException();
        }
    }
}
