using CloudCustomers.API.Models;
using System;

public class UsersService : IUsersService
{
    Task<List<User>> IUsersService.GetAllUsers()
    {
        throw new NotImplementedException();
    }
}