using System;
using System.Collections.Generic;
using System.Linq;
using AdminDashboard.Models;
using AdminDashboard.Patterns.Decorator;

namespace AdminDashboard
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<User>();

            Console.WriteLine("Welcome to the Admin Dashboard!");

            // Step 1: Input the number of users
            int userCount;
            while (true)
            {
                Console.Write("Enter the number of users: ");
                var input = Console.ReadLine() ?? string.Empty; // Handle null input
                if (int.TryParse(input, out userCount) && userCount > 0)
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }

            // Step 2: Input user details
            for (int i = 0; i < userCount; i++)
            {
                Console.WriteLine($"\nEnter details for User {i + 1}:");

                // Input ID
                int id;
                while (true)
                {
                    Console.Write("ID: ");
                    var input = Console.ReadLine() ?? string.Empty; // Handle null input
                    if (int.TryParse(input, out id))
                    {
                        break;
                    }
                    Console.WriteLine("Invalid ID. Please enter a valid integer.");
                }

                // Input Name
                string name;
                while (true)
                {
                    Console.Write("Name: ");
                    name = Console.ReadLine() ?? string.Empty; // Handle null input
                    if (!string.IsNullOrWhiteSpace(name))
                    {
                        break;
                    }
                    Console.WriteLine("Invalid name. Please enter a non-empty string.");
                }

                // Input Role
                string role;
                while (true)
                {
                    Console.Write("Role: ");
                    role = Console.ReadLine() ?? string.Empty; // Handle null input
                    if (!string.IsNullOrWhiteSpace(role))
                    {
                        break;
                    }
                    Console.WriteLine("Invalid role. Please enter a non-empty string.");
                }

                // Add user to the list
                users.Add(new User { Id = id, Name = name, Role = role });
            }

            if (users.Count == 0)
            {
                Console.WriteLine("\nNo valid users were entered. Exiting...");
                return;
            }

            // Step 3: Filter users by role
            string roleToFilter;
            while (true)
            {
                Console.Write("\nEnter the role to filter (e.g., Admin, User): ");
                roleToFilter = Console.ReadLine() ?? string.Empty; // Handle null input
                if (!string.IsNullOrWhiteSpace(roleToFilter))
                {
                    break;
                }
                Console.WriteLine("Invalid role. Please enter a non-empty string.");
            }

            // Apply the filter using the Strategy Pattern
            IUserFilter filter = new RoleFilter(new BasicFilter(), roleToFilter);
            var filteredUsers = filter.Apply(users);

            // Step 4: Display the filtered users
            Console.WriteLine($"\nUsers with the role '{roleToFilter}':");
            if (filteredUsers.Any())
            {
                foreach (var user in filteredUsers)
                {
                    Console.WriteLine($"- ID: {user.Id}, Name: {user.Name}, Role: {user.Role}");
                }
            }
            else
            {
                Console.WriteLine("No users found with the specified role.");
            }

            Console.WriteLine("\nThank you for using the Admin Dashboard!");
        }
    }
}
