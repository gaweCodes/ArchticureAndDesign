namespace Memento
{
    internal class Program
    {
        private static void Main()
        {
            var o = new Originator {State = "On"};
            var caretaker = new Caretaker {Memento = o.CreateMemento()};
            o.State = "Off";
            o.SetMemento(caretaker.Memento);
        }
    }
}
