using System;

namespace Database.Exceptions
{
    public class TableDataNotFound : Exception
    {
        public TableDataNotFound(string message) : base(message) { }
    }
}
