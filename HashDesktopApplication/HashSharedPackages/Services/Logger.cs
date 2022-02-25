using HashSharedPackages.Interfaces;
using System;

namespace HashSharedPackages.Services
{
    public class Logger : ILogger
    {
        private readonly string filePath;
        
        public Logger(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException(string.Concat(nameof(Logger), ": ", nameof(filePath)));

            this.filePath = filePath;
        }

        public void Save(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentException(string.Concat(nameof(Logger), ":", nameof(message)));
        }

        public void GetAll()
        {

        }

        public void Clear()
        {

        }
    }
}
