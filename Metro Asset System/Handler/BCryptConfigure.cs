using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro_Asset_System.Handler
{
    public class BCryptConfigure
    {
        public string HashPassword(string password)
        {
            string salt = BCrypt.Net.BCrypt.GenerateSalt(12);
            return BCrypt.Net.BCrypt.HashPassword(password, salt);
        }

        public bool Verify(string passwordInput, string password) 
        {
            return BCrypt.Net.BCrypt.Verify(passwordInput, password);            
        }
    }
}
