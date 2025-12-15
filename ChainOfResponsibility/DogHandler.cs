using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class DogHandler : AbstractHandler
    {
        public DogHandler(IHandler handler) : base(handler) { }

        public override object Handle(object request)
        {
            {
                if (request.ToString() == "Мясо")
                {
                    HandlerEvent($"Собака съела {request}");
                    return true;
                }
                else
                {
                    Console.WriteLine($"- Собака не смогла съесть {request.ToString()}");
                    return base.Handle(request);
                }
            }
        }
    }
}
