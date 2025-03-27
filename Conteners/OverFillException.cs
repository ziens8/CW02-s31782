using System;

namespace Conteners
{
    public class OverFillException : Exception
    {
        public OverFillException(string message) : base(message)
        {
        }
    }
}