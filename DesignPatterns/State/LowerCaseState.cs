using System;

namespace State
{
    internal class LowerCaseState : IState
    {
        public void WriteName(StateContext context, string name)
        {
            Console.WriteLine(name.ToLower());
            context.State = new MultipleUpperCaseState();
        }
    }
}
