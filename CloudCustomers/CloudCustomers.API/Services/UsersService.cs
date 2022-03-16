using CloudCustomers.API.Models;
using Microsoft.Extensions.Options;
using System;
using UsersAPI.Config;

public class UsersService : IUsersService
{
    private readonly HttpClient _httpClient;
    private readonly UserApiOptions _apiConfig;

    public UsersService(HttpClient httpClient, 
                        IOptions<UserApiOptions> apiConfig)
    {
        _httpClient = httpClient;
        _apiConfig = apiConfig.Value;
    }

    public async Task<List<User>> GetAllUsers()
    {
        var usersResponse = await _httpClient.GetAsync("https://foo.com");
        if (usersResponse.StatusCode == System.Net.HttpStatusCode.NotFound)
        {
            return new List<User>();
        }
        var responseContent = usersResponse.Content;
        var allUsers = await responseContent.ReadFromJsonAsync<List<User>>();
        return allUsers.ToList();
    }
}