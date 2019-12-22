using System;

namespace State
{
    internal class MultipleUpperCaseState : IState
    {
        private int _count;
        public void WriteName(StateContext context, string name)
        {
            Console.WriteLine(name.ToUpper());
            if (++_count > 1)
                context.State = new LowerCaseState();
        }
    }
}
