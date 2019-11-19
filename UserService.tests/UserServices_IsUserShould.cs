using System;
using Xunit;

namespace UserService.tests
{
    public class UserServices_IsUserShould
    {
        private readonly UserServices _userService;
        public UserServices_IsUserShould()
        {
            _userService = new UserServices();
        }

        [Theory]
        [InlineData("jonas@bruus.dk")]
        [InlineData("jonas@bruus.d")]
        [InlineData(null)]
        //make trying other var.
        public void IsEamil_InputIsEmail_RetrunTrue(string value)
        {
            var resault = _userService.IsEmail(value);
            Assert.True(resault, "not email");
        }
        [Theory]
        [InlineData("Aa123456&")]
        //[InlineData("123456&")]
        [InlineData("Password123&")]
        public void IsPasswordStrong_InputPassword_RetrunTrue(string value)
        {
            var resault = _userService.IsPasswordStrong(value);
            Assert.True(resault, "pasword not Strong");
        }


    }
}
