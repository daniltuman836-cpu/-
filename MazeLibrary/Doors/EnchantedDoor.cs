using MazeLibrary.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Doors
{
    public class EnchantedDoor : Door
    {
        public EnchantedDoor(Room room1, Room room2) : base(room1, room2) { }

        protected override void EnterIsOpen(Room room1, Room room2)
        {
            Console.WriteLine("Вы прошли через магическую дверь между {0} и {1} комнатами", room1.Number, room2.Number);
        }
    }
}
