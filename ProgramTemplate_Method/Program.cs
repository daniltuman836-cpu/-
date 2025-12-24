using Template_Method;
namespace ProgramTemplate_Method
{
    class Program
    {
        public static void Main(string[] args)
        {
            CaffeineBeverage tea = new Tea();
            CaffeineBeverage coffee = new Coffee();
            Console.WriteLine("Готовим чай:");
            tea.PrepareRecipe();
            Console.WriteLine();
            Console.WriteLine("Готовим кофе:");
            coffee.PrepareRecipe();
            Console.ReadKey();
        }
    }
}