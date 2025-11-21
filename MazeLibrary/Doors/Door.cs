using MazeLibrary.Rooms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Doors
{
    public class Door : MapSite
    {
        private Room _room1 { get; }
        private Room _room2 { get; }
        private bool IsOpen { get; } = true;

        public Door(Room room1, Room room2)
        {
            _room1 = room1;
            _room2 = room2;
        }

        public override void Enter()
        {
            if (IsOpen)
            {
                Console.WriteLine("Вы прошли через дверь.");
            }
            else
            {
                Console.WriteLine("Дверь закрыта!");
            }
        }

        protected virtual void EnterIsOpen(Room room1, Room room2)
        {
            Console.WriteLine("Вы прошли через дверь между {0} и {1} комнатами", _room1.Number, _room2.Number);
        }
    }
}
