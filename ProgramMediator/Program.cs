using System;
using Mediator;

namespace ProgramMediator
{
    class Program
    {
        static void Main(string[] args)
        {
            IChatMediator chatMediator = new ChatMediator();
            User user1 = new ConcreteUser(chatMediator, "Максим");
            User user2 = new ConcreteUser(chatMediator, "Василий");
            User user3 = new ConcreteUser(chatMediator, "Валерий");
            chatMediator.AddUser(user1);
            chatMediator.AddUser(user2);
            chatMediator.AddUser(user3);
            user1.Send("Сообщение");
            Console.WriteLine();
            user2.Send("Стикер");
            Console.WriteLine();
            user3.Send("Ссылку");
            Console.ReadLine();
        }
    }
}