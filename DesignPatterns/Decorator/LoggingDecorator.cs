using Composite;

namespace Decorator
{
    public abstract class LoggingDecorator : IEmployee
    {
        protected IEmployee Directory;
        protected LoggingDecorator(IEmployee directory)
        {
            Directory = directory;
        }
        public abstract void ShowEmployeeDetails();
    }
}
