using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashDesktopApplication.Models
{
    public class LoginData
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public LoginData()
        {
            UserName = string.Empty;
            Password = string.Empty;
        }
    }
}
