using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            _flyable = new FlyNoWay();
            _quackable = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
