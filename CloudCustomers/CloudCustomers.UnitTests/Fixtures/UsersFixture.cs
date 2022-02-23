using CloudCustomers.API.Models;
using System.Collections.Generic;

namespace CloudCustomers.UnitTests.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() =>
            new()
            {
                new User
                {
                    Name = "Test User 1",
                    Email = "test1@mail.com",
                    Address = new Address
                    {
                        Street = "Calvari",
                        City = "Crevillent",
                        ZipCode = "033330"
                    }
                },
                new User
                {
                    Name = "Test User 2",
                    Email = "test2@mail.com",
                    Address = new Address
                    {
                        Street = "Calvari",
                        City = "Crevillent",
                        ZipCode = "033330"
                    }
                },
                new User
                {
                    Name = "Test User 3",
                    Email = "test3@mail.com",
                    Address = new Address
                    {
                        Street = "Calvari",
                        City = "Crevillent",
                        ZipCode = "033330"
                    }
                },
            };
    }
}
