namespace AweCoreDemo.Models
{
    public class EntityMissingException : AwesomeDemoException
    {
        public EntityMissingException(string message) : base(message)
        {
        }

        public EntityMissingException()
        {
        }
    }
}