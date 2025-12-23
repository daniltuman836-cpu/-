using State;
namespace ProgramState
{
    class Program
    {
        static void Main()
        {
            GumballMachine machine = new GumballMachine(2);
            machine.InsertQuarter();
            machine.TurnCrank();
            Console.WriteLine();
            machine.InsertQuarter();
            machine.EjectQuarter();
            machine.TurnCrank();
            Console.WriteLine();
            machine.InsertQuarter();
            machine.TurnCrank();
            machine.InsertQuarter();
        }
    }
}