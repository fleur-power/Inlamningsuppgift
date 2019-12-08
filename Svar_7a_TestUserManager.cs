using System;
using Xunit;
using Svar_7a;

namespace Svar_7a_Test
{
    public class TestUserManager
    {
        [Fact]
        public void ChangePassword_ShouldReturnTrueForCorrectParameters()
        {
            // arrange:
            string correctUsername = "apa";
            string correctOldPassword = "bepa";
            UserManager um = new UserManager(correctUsername, correctOldPassword);
            string correctNewPassword = "cepa"; 
            // act:  
            bool result = um.ChangePassword(correctUsername,  correctOldPassword, correctNewPassword); 
            // assert:
            Assert.True(result);
        }
    }
}
