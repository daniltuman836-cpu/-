using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class GumballMachine
    {
        private IState _state;
        private int _count;

        public GumballMachine(int count)
        {
            _count = count;
            _state = count > 0
                ? new NoQuarterState(count)
                : new SoldOutState();
        }

        public void InsertQuarter()
        {
            _state = _state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _state = _state.EjectQuarter();
        }

        public void TurnCrank()
        {
            _state = _state.TurnCrank();
            _state = _state.Dispense();
        }

        public int GetCount() => _count;

        public void ReleaseBall()
        {
            if (_count <= 0)
                throw new InvalidOperationException("Жевательная резинка закончилась");

            Console.WriteLine("Жевательная резинка выкатывается из автомата");
            _count--;
        }
    }

}
