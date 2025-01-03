using System.Collections.Generic;
using AdminDashboard.Models;

namespace AdminDashboard.Patterns.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users = new List<User>();

        public void AddUser(User user) => _users.Add(user);

        public IEnumerable<User> GetAllUsers() => _users;
    }
}
