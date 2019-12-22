namespace Command
{
    internal class Program
    {
        private static void Main()
        {
            TestingByState(true);
            TestingByState(false);
        }

        private static void TestingByState(bool isOn)
        {
            ISwitchable lamp = new Light();
            ICommand switchClose = new CloseSwitchCommand(lamp);
            ICommand switchOpen = new OpenSwitchCommand(lamp);
            var @switch = new Switch(switchClose, switchOpen);
            if (isOn) @switch.Open();
            else @switch.Close();
        }
    }
}
