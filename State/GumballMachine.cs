using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class GumballMachine
    {
        private IState _soldOutState;
        private IState _noQuarterState;
        private IState _hasQuarterState;
        private IState _soldState;
        private IState _state;
        private int _count;
        public GumballMachine(int count)
        {
            _count = count;

            _soldOutState = new SoldOutState(this);
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldState(this);
            _state = (_count > 0) ? _noQuarterState : _soldOutState;
        }

        public void InsertQuarter() 
        {
            _state.InsertQuarter();
        }

        public void EjectQuarter() 
        {
            _state.EjectQuarter();
        } 

        public void TurnCrank()
        {
            _state.TurnCrank();
            _state.Dispense();
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public IState GetSoldOutState()
        {
            return _soldOutState;
        }

        public IState GetNoQuarterState()
        {
            return _noQuarterState;
        }

        public IState GetHasQuarterState()
        {
            return _hasQuarterState;
        }

        public IState GetSoldState()
        {
            return _soldState;
        }

        public void ReleaseBall()
        {
            if (_count > 0)
            {
                Console.WriteLine("Выдача жевательной резинки\r\n");
                _count--;
            }
        }

        public int GetCount()
        { 
            return _count;
        }
    }
}
