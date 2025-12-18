using System.Globalization;
using Memento;
namespace ProgramMemento
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator("Super-duper-super-puper-super");
            Caretaker caretaker = new Caretaker(originator);
            caretaker.Backup();
            originator.DoSomething();
            caretaker.Backup();
            originator.DoSomething();
            caretaker.Backup();
            originator.DoSomething();
            Console.WriteLine();
            caretaker.ShowHistory();
            Console.WriteLine("\nВыполняем откат\n");
            caretaker.Undo();
            Console.WriteLine("\nЕщё раз\n");
            caretaker.Undo();
            Console.WriteLine("\nПовтор действия\n");
            caretaker.Redo();
            caretaker.ShowHistory();
            Console.ReadLine();
        }
    }
}