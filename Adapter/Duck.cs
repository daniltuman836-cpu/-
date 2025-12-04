using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Duck : IDuck
    {
        public void Name()
        {
            Console.WriteLine("Утка");
        }

        public void Voice()
        {
            Console.WriteLine("кря");
        }

        public void CanFly()
        {
            Console.WriteLine("Может летать");
        }
    }
}
