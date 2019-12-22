namespace Mediator
{
    internal class BaseComponent
    {
        protected IMediator Mediator;
        protected BaseComponent(IMediator mediator = null)
        {
            Mediator = mediator;
        }
        public void SetMediator(IMediator mediator) => Mediator = mediator;
    }
}
