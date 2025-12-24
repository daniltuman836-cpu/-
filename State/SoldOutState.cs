using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class SoldOutState : IState
    {
        public IState InsertQuarter()
        {
            Console.WriteLine("Жевательная резинка закончилась");
            return this;
        }

        public IState EjectQuarter()
        {
            Console.WriteLine("Монета не вставлена");
            return this;
        }

        public IState TurnCrank()
        {
            Console.WriteLine("Автомат пуст");
            return this;
        }

        public IState Dispense()
        {
            Console.WriteLine("Нечего выдавать");
            return this;
        }
    }

}
