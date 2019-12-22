namespace Mediator
{
    internal interface IMediator
    {
        void Notify(object sender, string e);
    }
}
