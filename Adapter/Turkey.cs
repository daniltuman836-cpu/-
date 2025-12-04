using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Turkey
    {
        public void SpecificName()
        {
            Console.WriteLine("Индюк");
        }

        public void SpecificVoice()
        {
            Console.WriteLine("гу-гу");
        }

        public void SpecificCanFly()
        {
            Console.WriteLine("На короткие растояния");
        }
    }
}
