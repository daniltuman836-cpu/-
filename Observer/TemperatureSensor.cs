using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class TemperatureSensor : ISubject
    {
        public int Temperature { get; private set; }
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            Console.WriteLine("Добавлен наблюдатель");
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("Наблюдатель удалён");
        }

        public void Notify()
        {
            Console.WriteLine("Уведомление всех наблюдателей...");
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void ChangeTemperature()
        {
            Temperature = new Random().Next(15, 30);
            Console.WriteLine($"Текущая температура = {Temperature}");
            Notify();
        }
    }
}
