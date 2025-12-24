using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            _flyable = new FlyNoWay();
            _quackable = new Squack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a rubber duck");
        }
    }
}
