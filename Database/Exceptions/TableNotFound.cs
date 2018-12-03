using System;

namespace Database.Exceptions
{
    class TableNotFound : Exception
    {
        public TableNotFound(string message) : base(message) { }
    }
}
