using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Chef
    {
        public Chef() {}
       

        public void Cook(string dish)
        {
            Console.WriteLine($"Шеф готовит: {dish}");
        }

        public void CancelCooking(string dish)
        {
            Console.WriteLine($"Шеф отменил приготовление: {dish}");
        }
    }

}
