using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class HasQuarterState : IState
    {
        private GumballMachine _machine;

        public HasQuarterState(GumballMachine machine)
        {
            _machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Вы уже вставили монету");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Монета возвращена");
            _machine.SetState(_machine.GetNoQuarterState());
        }

        public void TurnCrank()
        {
            Console.WriteLine("Вы повернули рычаг");
            _machine.SetState(_machine.GetSoldState());
        }

        public void Dispense()
        {
            Console.WriteLine("Жевательная резинка не выдана");
        }
    }

}
