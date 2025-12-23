using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class SoldState : IState
    {
        private GumballMachine _machine;

        public SoldState(GumballMachine machine)
        {
            _machine = machine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Пожалуйста, подождите — жевательная резинка уже выдаётся");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Извините, вы уже повернули рычаг");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Повторный поворот рычага не даст дополнительную жевательную резинку");
        }

        public void Dispense()
        {
            _machine.ReleaseBall();

            if (_machine.GetCount() == 0)
            {
                Console.WriteLine("Жевательная резинка закончилась");
                _machine.SetState(_machine.GetSoldOutState());
            }
            else
            {
                _machine.SetState(_machine.GetNoQuarterState());
            }
        }
    }

}
