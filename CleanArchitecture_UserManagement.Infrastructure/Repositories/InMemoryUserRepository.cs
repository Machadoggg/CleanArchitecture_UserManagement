using CleanArchitecture_UserManagement.Domain.Entities;
using CleanArchitecture_UserManagement.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture_UserManagement.Infrastructure.Repositories
{
    public class InMemoryUserRepository : IUserRepository
    {
        //private readonly List<User> _users = new List<User>();

        private readonly List<User> _users = new List<User>
            {
                new User
                {
                    Id = Guid.NewGuid(),
                    Username = "user1",
                    PasswordHash = "passwordHash1",
                    Email = "user1@example.com"
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    Username = "user2",
                    PasswordHash = "passwordHash2",
                    Email = "user2@example.com"
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    Username = "user3",
                    PasswordHash = "passwordHash3",
                    Email = "user3@example.com"
                }
            };


        public Task AddUserAsync(User user)
        {
            _users.Add(user);
            return Task.CompletedTask;
        }

        public Task<User> GetUserByUsernameAsync(string username)
        {
            return Task.FromResult(_users.FirstOrDefault(u => u.Username == username));

        }
    }
}
