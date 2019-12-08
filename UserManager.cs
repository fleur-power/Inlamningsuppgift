using System;
using System.Collections.Generic;
using System.Text;

namespace Svar_7a
{
    public class UserManager
    {
        // Should return TRUE if able to change the password
        public bool ChangePassword(string userName, string oldPassword, string newPassword)
        { /* not implemented yet */ return false; }  
        private string thisUser;
        private string currentPassword;
        public UserManager(string userName, string password)
        { thisUser = userName; currentPassword = password; }  
    }
}
