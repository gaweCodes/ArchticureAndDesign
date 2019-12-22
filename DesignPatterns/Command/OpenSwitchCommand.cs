namespace Command
{
    internal class OpenSwitchCommand : ICommand
    {
        private readonly ISwitchable _switchable;
        public OpenSwitchCommand(ISwitchable switchable)
        {
            _switchable = switchable;
        }
        public void Execute() => _switchable.PowerOn();
    }
}
