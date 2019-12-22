namespace Command
{
    internal class CloseSwitchCommand : ICommand
    {
        private readonly ISwitchable _switchable;
        public CloseSwitchCommand(ISwitchable switchable)
        {
            _switchable = switchable;
        }
        public void Execute() => _switchable.PowerOff();
    }
}
