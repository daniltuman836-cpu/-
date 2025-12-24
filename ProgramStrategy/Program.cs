using Strategy;

namespace ProgramStrategy
{
    class Program
    {
        public static void Main(string[] args)
        {
            RubberDuck rubberDuck = new RubberDuck();
            MallardDuck mallardDuck = new MallardDuck();
            ModelDuck modelDuck = new ModelDuck();

            List<Duck> ducks = new List<Duck>() { rubberDuck, mallardDuck, modelDuck };

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.PerformFly();
                duck.PerformQuack();
                duck.Swim();
                Console.WriteLine("-----------------------------");
            }

            modelDuck.Display();
            modelDuck.SetFly(new FlyRocketPowered());
            modelDuck.PerformFly();

            modelDuck.SetQuack(new Squack());
            modelDuck.PerformQuack();
        }
    }
}