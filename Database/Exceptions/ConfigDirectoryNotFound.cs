using System;

namespace Database.Exceptions
{
    public class ConfigDirectoryNotFound : Exception
    {
        public ConfigDirectoryNotFound(string message) : base(message) { }
    }
}
