using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class NoQuarterState : IState
    {
        private GumballMachine _machine;

        public NoQuarterState(GumballMachine machine)
        {
            _machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Вы вставили монету");
            _machine.SetState(_machine.GetHasQuarterState());
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Вы не вставили монету");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Вы повернули рычаг, но монеты нет");
        }

        public void Dispense()
        {
            Console.WriteLine("Сначала нужно заплатить");
        }
    }
}
