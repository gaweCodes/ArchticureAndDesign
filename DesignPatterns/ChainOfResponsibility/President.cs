using System;

namespace ChainOfResponsibility
{
    internal class President : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            Console.WriteLine(purchase.Amount < 100000.0
                ? $"{GetType().Name} approved request# {purchase.Number}"
                : $"Request# {purchase.Number} requires an executive meeting!");
        }
    }
}
