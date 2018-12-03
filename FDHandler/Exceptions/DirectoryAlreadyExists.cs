using System;

namespace FDHandler.Exceptions
{
    class DirectoryAlreadyExists : Exception
    {
        public DirectoryAlreadyExists(string message) : base(message) { }
    }
}
