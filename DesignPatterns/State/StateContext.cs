namespace State
{
    internal class StateContext
    {
        public IState State { private get; set; } = new LowerCaseState();
        public void WriteName(string name) => State.WriteName(this, name);
    }
}
