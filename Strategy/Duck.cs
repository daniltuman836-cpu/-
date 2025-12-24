using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class Duck
    {
        protected IFlyable _flyable;
        protected IQuackBehavior _quackable;

        public abstract void Display();

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public void PerformFly()
        {
            _flyable.Fly();
        }

        public void PerformQuack()
        {
            _quackable.Quack();
        }

        public void SetFly(IFlyable flyable)
        {
            _flyable = flyable;
        }

        public void SetQuack(IQuackBehavior quackable)
        {
            _quackable = quackable;
        }
    }
}
