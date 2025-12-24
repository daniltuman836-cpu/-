using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class AirConditioner : IObserver
    {
        public void Update(TemperatureSensor sensor)
        {
            int temp = sensor.Temperature;

            if (temp > 24)
            {
                Console.WriteLine("Кондиционер включён");
            }
            else
            {
                Console.WriteLine("Кондиционер выключен");
            }
        }
    }

}
