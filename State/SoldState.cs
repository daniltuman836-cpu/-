using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class SoldState : IState
    {
        private int _count;

        public SoldState(int count)
        {
            _count = count;
        }

        public IState InsertQuarter()
        {
            Console.WriteLine("Пожалуйста, подождите");
            return this;
        }

        public IState EjectQuarter()
        {
            Console.WriteLine("Вы уже повернули рычаг");
            return this;
        }

        public IState TurnCrank()
        {
            Console.WriteLine("Повторный поворот не сработает");
            return this;
        }

        public IState Dispense()
        {
            Console.WriteLine("Жевательная резинка выкатывается из автомата");
            _count--;

            return _count == 0
                ? new SoldOutState()
                : new NoQuarterState(_count);
        }
    }

}
