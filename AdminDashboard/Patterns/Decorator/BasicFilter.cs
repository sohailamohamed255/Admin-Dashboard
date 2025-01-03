using System.Collections.Generic;
using AdminDashboard.Models;

namespace AdminDashboard.Patterns.Decorator
{
    public class BasicFilter : IUserFilter
    {
        public IEnumerable<User> Apply(IEnumerable<User> users)
        {
            // Return the users as-is, without any filtering
            return users;
        }
    }
}
