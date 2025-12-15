using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Command
{
    public class ServeCommand : IOrderCommand
    {
        private readonly Waiter _waiter;
        private readonly string _dish;

        public ServeCommand(Waiter waiter, string dish)
        {
            _waiter = waiter;
            _dish = dish;
        }

        public void Execute()
        {
            _waiter.Serve(_dish);
        }

        public void Undo()
        {
            _waiter.UndoServe(_dish);
        }
    }

}
