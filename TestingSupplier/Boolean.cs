using System;

namespace TestingSupplier
{
    internal class Boolean
    {
        public static implicit operator Boolean(bool v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator bool(Boolean v)
        {
            throw new NotImplementedException();
        }
    }
}