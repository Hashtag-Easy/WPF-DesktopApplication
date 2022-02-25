using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSharedPackages.Services
{
    public class Session
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
