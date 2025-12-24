using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Windows : IObserver
    {
        public void Update(TemperatureSensor sensor)
        {
            int temp = sensor.Temperature;

            if (temp < 18)
            {
                Console.WriteLine("Окна закрыты");
            }
            else if (temp > 24)
            {
                Console.WriteLine("Окна открыты");
            }
        }
    }

}
