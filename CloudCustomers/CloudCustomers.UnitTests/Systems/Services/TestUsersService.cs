using System.Threading.Tasks;
using Xunit;

namespace CloudCustomers.UnitTests.Systems.Services
{
    public class TestUsersService
    {
        [Fact]
        public async Task GetAllUsers_WhenCalled_InvokesHttpGetRequest()
        {
            var sut = new UsersService();

            await sut.GetAllUsers();
        }
        
    }
}
