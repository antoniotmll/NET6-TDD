using CloudCustomers.API.Models;
using System;

public class UsersService : IUsersService
{
    public UsersService()
    {

    }

    Task<List<User>> IUsersService.GetAllUsers()
    {
        throw new NotImplementedException();
    }
}