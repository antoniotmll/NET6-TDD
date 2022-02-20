using CloudCustomers.API.Controllers;
using CloudCustomers.API.Models;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace CloudCustomers.UnitTests.Systems.Controllers;

public class TestUsersController
{
    [Fact]
    public async Task Get_OnSuccess_ReturnsStatusCode200()
    {
        var mockUserService = new Mock<IUsersService>();
        var sut = new UsersController(mockUserService.Object);

        var result = (OkObjectResult) await sut.Get();

        result.StatusCode.Should().Be(200);
    }

    [Fact]
    public async Task Get_OnSuccess_InvokesUserServiceExactlyOnce()
    {

        var mockUsersService = new Mock<IUsersService>();
        mockUsersService
            .Setup(service => service.GetAllUsers())
            .ReturnsAsync(new List<User>());

        var sut = new UsersController(mockUsersService.Object);

        var result = await sut.Get();

        mockUsersService.Verify(
            service => service.GetAllUsers(),
            Times.Once());
    }

    [Fact]
    public async Task Get_OnSuccess_ReturnsListOfUsers()
    {
        var mockUserService = new Mock<IUsersService>();

        mockUserService.
            Setup(service => service.GetAllUsers())
            .ReturnsAsync(new List<User>());

        var sut = new UsersController(mockUserService.Object);

        var result = await sut.Get();

        result.Should().BeOfType<OkObjectResult>();
        var objectResult = (OkObjectResult) result;
        objectResult.Value.Should().BeOfType<List<User>>();
    }
}