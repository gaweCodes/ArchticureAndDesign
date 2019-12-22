namespace ChainOfResponsibility
{
    internal abstract class Approver
    {
        protected Approver Successor;
        public void SetSuccessor(Approver successor)
        {
            Successor = successor;
        }
        public abstract void ProcessRequest(Purchase purchase);
    }
}
