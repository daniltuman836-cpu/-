using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Client
    {
        public static void Feed(IHandler handler)
        {
            foreach (var food in new List<string> { "Орех", "Яблоко", "Банан", "Арбуз", "Мясо" })
            {
                var result = handler.Handle(food);
                if (result != null)
                {
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine($"? {food} не съели");
                }
            }
        }
    }
}
