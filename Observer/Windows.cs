using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Windows : IObserver
    {
        public void Update(ISubject subject)
        {
            int temp = (subject as TemperatureSensor).Temperature;
            if (temp < 18)
            {
                Console.WriteLine("Окна закрыты");
            }
            if (temp > 24)
            {
                Console.WriteLine("Окна открыты");
            }
        }

        public void TemperatureChanged(int temperature)
        {
            if (temperature < 18)
            {
                Console.WriteLine("EVENT >>> Окна закрыты");
            }
            if (temperature > 24)
            {
                Console.WriteLine("EVENT >>> Окна открыты");
            }
        }
    }

}
