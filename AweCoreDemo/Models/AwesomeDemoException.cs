using System;

namespace AweCoreDemo.Models
{
    public class AwesomeDemoException : Exception
    {
        public AwesomeDemoException()
        {
        }

        public AwesomeDemoException(string message):base(message)
        {
        }
    }
}