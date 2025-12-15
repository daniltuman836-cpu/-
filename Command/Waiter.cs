using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Waiter
    {
        public void Serve(string dish)
        {
            Console.WriteLine($"Официант подал блюдо: {dish}");
        }

        public void UndoServe(string dish)
        {
            Console.WriteLine($"Официант сообщает об отмене блюда: {dish}");
        }
    }
}
