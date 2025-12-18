using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Caretaker
    {
        private Stack<IMemento> _undoStack = new Stack<IMemento>();
        private Stack<IMemento> _redoStack = new Stack<IMemento>();
        private Originator _originator;

        public Caretaker(Originator originator)
        {
            this._originator = originator;
        }

        public void Backup()
        {
            Console.WriteLine("\nСохраняем состояния");
            _undoStack.Push(_originator.Save());
            _redoStack.Clear();
        }

        public void Undo()
        {
            if (_undoStack.Count == 0)
            {
                Console.WriteLine("Нечего отменять.");
                return;
            }

            var memento = _undoStack.Pop();
            _redoStack.Push(_originator.Save());

            Console.WriteLine("Откат к состоянию: " + memento.GetName());
            _originator.Restore(memento);
        }

        public void Redo()
        {
            if (_redoStack.Count == 0)
            {
                Console.WriteLine("Нечего повторять.");
                return;
            }

            var memento = _redoStack.Pop();
            _undoStack.Push(_originator.Save());

            Console.WriteLine("Повтор к состоянию: " + memento.GetName());
            _originator.Restore(memento);
        }

        public void ShowHistory()
        {
            Console.WriteLine("\nИстория отмен");
            foreach (var memento in _undoStack)
            {
                Console.WriteLine(memento.GetName());
            }

            Console.WriteLine("\nИстория повторов:");
            foreach (var memento in _redoStack)
            {
                Console.WriteLine(memento.GetName());
            }
        }
    }
}
