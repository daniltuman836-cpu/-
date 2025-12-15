using Command;
using System.Windows.Input;
namespace ProgramCommand
{
    class Program
    {
        static void Main()
        {
            Chef chef = new Chef();
            Waiter waiter = new Waiter();
            IOrderCommand cook = new CookCommand(chef, "Стейк");
            IOrderCommand serve = new ServeCommand(waiter, "Стейк");
            IOrderCommand order = new OrderCommand(cook, serve);
            order.Execute();
            Console.WriteLine();
            order.Undo();
        }
    }
}