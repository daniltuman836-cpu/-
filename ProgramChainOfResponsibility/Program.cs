using ChainOfResponsibility;
using System.Data.SqlTypes;
using System.Xml.XPath;

namespace ProgramChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            MonkeyHandler monkey = new MonkeyHandler(null);
            DogHandler dog = new DogHandler(monkey);
            SquirrelHandler squirrel = new SquirrelHandler(dog);
            monkey.OnHandled += HanderEvent;
            Client.Feed(monkey);
            dog.OnHandled += HanderEvent;
            Client.Feed(dog);
            squirrel.OnHandled += HanderEvent;
            Client.Feed(squirrel);
        }

        public static void HanderEvent(string message)
        {
            Console.WriteLine($"[Event] {message}");
        }
    }
}