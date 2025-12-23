using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class AirConditioner : IObserver
    {
        public void Update(ISubject subject)
        {
            int temp = (subject as TemperatureSensor).Temperature;

            if (temp < 18)
            {
                Console.WriteLine("Кондиционер выключен");
            }

            if (temp >= 18 && temp <= 24)
            {
                Console.WriteLine("Кондиционер выключен");
            }

            if (temp > 24)
            {
                Console.WriteLine("Кондиционер включён");
            }
        }

        public void TemperatureChanged(int temperature)
        {
            if (temperature < 18)
            {
                Console.WriteLine("EVENT >>> Кондиционер выключен");
            }

            if (temperature >= 18 && temperature <= 24)
            {
                Console.WriteLine("EVENT >>> Кондиционер выключен");
            }

            if (temperature > 24)
            {
                Console.WriteLine("EVENT >>> Кондиционер включён");
            }
        }
    }
}
