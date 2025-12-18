using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Originator
    {
        private string _state;

        public Originator(string state)
        {
            this._state = state;
            Console.WriteLine("Начальное состояние: " + state);
        }

        public void DoSomething()
        {
            Console.WriteLine("Выполнение действия");
            this._state = this.GenerateRandomString(30);
            Console.WriteLine($"Состояние изменилось на: {_state}");
        }

        private string GenerateRandomString(int length = 10)
        {
            string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = string.Empty;

            while (length > 0)
            {
                result += allowedSymbols[new Random().Next(0, allowedSymbols.Length)];

                Thread.Sleep(12);
                length--;
            }
            return result;
        }

        public IMemento Save()
        {
            return new ConcreteMemento(this._state);
        }

        public void Restore(IMemento memento)
        {
            if (!(memento is ConcreteMemento))
            {
                throw new Exception("Неизвестный класс снимка " + memento.ToString());
            }
            this._state = memento.GetState();
            Console.WriteLine($"Состояние восстановлено: {_state}");
        }
    }
}
