using System.Collections.Generic;
using System.Linq;
using AdminDashboard.Models;

namespace AdminDashboard.Patterns.Decorator
{
    public class RoleFilter : IUserFilter
    {
        private readonly IUserFilter _innerFilter;
        private readonly string _role;

        public RoleFilter(IUserFilter innerFilter, string role = "Admin")
        {
            _innerFilter = innerFilter;
            _role = role;
        }

        public IEnumerable<User> Apply(IEnumerable<User> users)
        {
            // Filter users by role
            return _innerFilter.Apply(users).Where(u => u.Role == _role);
        }
    }
}
