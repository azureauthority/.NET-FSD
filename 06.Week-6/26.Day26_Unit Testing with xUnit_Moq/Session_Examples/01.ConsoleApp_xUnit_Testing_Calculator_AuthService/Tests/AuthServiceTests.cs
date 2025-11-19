using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ConsoleApp4.Tests
{
    public class AuthServiceTests
    {
        [Fact]
        public void Login_ShouldReturnTrue_ForValidCredentials()
        {
            bool result = AuthService.Login("admin", "admin123");
            Assert.True(result);
        }


        [Fact]
        public void Login_ShouldReturnFalse_ForInvalidUser()
        {
            bool result = AuthService.Login("baduser", "1234");
            Assert.False(result);
        }


        [Fact]
        public void Login_ShouldReturnFalse_ForInvalidPassword()
        {
            bool result = AuthService.Login("admin", "hello");
            Assert.False(result);
        }


        [Theory]
        [InlineData("", "1234")]
        [InlineData("admin", "")]
        [InlineData(null, "1234")]
        [InlineData("admin", null)]
        public void Login_ShouldReturnFalse_ForEmptyOrNullInputs(string uid, string pwd)
        {
            bool result = AuthService.Login(uid, pwd);
            Assert.False(result);
        }
    }
}
