using System;

namespace AweCoreDemo.Models
{
    public class AweArgumentNullException : ArgumentNullException
    {
        public AweArgumentNullException(string paramName) : base(paramName)
        {
        }
    }
}