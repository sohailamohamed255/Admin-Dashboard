using System.Collections.Generic;
using AdminDashboard.Models;

namespace AdminDashboard.Patterns.Repository
{
    public interface IUserRepository
    {
        void AddUser(User user);
        IEnumerable<User> GetAllUsers();
    }
}
