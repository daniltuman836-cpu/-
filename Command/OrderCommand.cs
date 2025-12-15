using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Command
{
    public class OrderCommand : IOrderCommand
    {
        private readonly List<IOrderCommand> _commands = new List<IOrderCommand>();

        public OrderCommand(params IOrderCommand[] commands)
        {
            _commands.AddRange(commands);
        }

        public void Execute()
        {
            Console.WriteLine("Выполнение заказа");
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            Console.WriteLine("Отмена заказа");
            for (int i = _commands.Count - 1; i >= 0; i--)
            {
                _commands[i].Undo();
            }
        }
    }
}
