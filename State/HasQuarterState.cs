using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class HasQuarterState : IState
    {
        private int _count;

        public HasQuarterState(int count)
        {
            _count = count;
        }

        public IState InsertQuarter()
        {
            Console.WriteLine("Вы уже вставили монету");
            return this;
        }

        public IState EjectQuarter()
        {
            Console.WriteLine("Монета возвращена");
            return new NoQuarterState(_count);
        }

        public IState TurnCrank()
        {
            Console.WriteLine("Вы повернули рычаг");
            return new SoldState(_count);
        }

        public IState Dispense()
        {
            Console.WriteLine("Сначала поверните рычаг");
            return this;
        }
    }


}
