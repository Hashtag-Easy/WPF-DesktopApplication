using HashSharedPackages.Interfaces;
using HashSharedPackages.Models;
using System;

namespace HashSharedPackages.Services
{
    public class Session<T>
    {
        public IToken Token { get; set; }
        public DateTime ExpireDate { get; set; }
        public T? User { get; set; }

        /// <summary>
        /// Create session that will be valid for 7 days.
        /// </summary>
        public Session(IToken token)
        {
            Token = token;

            ExpireDate = DateTime.Now.AddDays(7);  
        }

        /// <summary>
        /// Create session that will be valid for provided period of time.
        /// </summary>
        /// <param name="expireDate">Session expire date, if expire date will be shorter than 7 days session will be valid for 7 days.</param>
        public Session(IToken token, DateTime expireDate)
        {
            Token = token;

            if (DateTime.Now.AddDays(7) > expireDate)
                ExpireDate = DateTime.Now.AddDays(7);
            else
                ExpireDate = expireDate;
        }
    }
}
