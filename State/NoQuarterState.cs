using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class NoQuarterState : IState
    {
        private int _count;

        public NoQuarterState(int count)
        {
            _count = count;
        }

        public IState InsertQuarter()
        {
            Console.WriteLine("Вы вставили монету");
            return new HasQuarterState(_count);
        }

        public IState EjectQuarter()
        {
            Console.WriteLine("Вы не вставили монету");
            return this;

        }

        public IState TurnCrank()
        {
            Console.WriteLine("Вы повернули рычаг, но монеты нет");
            return this;

        }

        public IState Dispense()
        {
            Console.WriteLine("Сначала нужно заплатить");
            return this;

        }
    }
}
