using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class SoldOutState : IState
    {
        private GumballMachine _machine;

        public SoldOutState(GumballMachine machine)
        {
            _machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Невозможно вставить монету — жевательная резинка закончилась");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Вы не вставили монету");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Вы повернули рычаг, но жевательной резинки нет");
        }

        public void Dispense()
        {
            Console.WriteLine("Жевательная резинка не выдана");
        }
    }

}
