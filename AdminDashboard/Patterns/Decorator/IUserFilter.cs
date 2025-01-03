using System.Collections.Generic;
using AdminDashboard.Models;

namespace AdminDashboard.Patterns.Decorator
{
    public interface IUserFilter
    {
        IEnumerable<User> Apply(IEnumerable<User> users);
    }
}
