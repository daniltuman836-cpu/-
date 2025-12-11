using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoteControlLibrary;

namespace RemoteControlProxy
{
    public class RemoteControl
    {
        public static void Use(Power power, IDriver driver)
        {
            power.TurnOn();
            driver.Operation();
            power.TurnOff();
        }
    }
}
