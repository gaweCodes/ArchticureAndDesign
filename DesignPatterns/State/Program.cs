namespace State
{
    internal class Program
    {
        private static void Main()
        {
            var context = new StateContext();
            context.WriteName("Monday");
            context.WriteName("Tuesday");
            context.WriteName("Wednesday");
            context.WriteName("Thursday");
            context.WriteName("Friday");
            context.WriteName("Saturday");
            context.WriteName("Sunday");
        }
    }
}
