using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Command
{
    public class CookCommand : IOrderCommand
    {
        private readonly Chef _chef;
        private readonly string _dish;

        public CookCommand(Chef chef, string dish)
        {
            _chef = chef;
            _dish = dish;
        }

        public void Execute()
        {
            _chef.Cook(_dish);
        }

        public void Undo()
        {
            _chef.CancelCooking(_dish);
        }
    }
}
