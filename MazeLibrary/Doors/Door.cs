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
        protected Room Room1 { get; }
        protected Room Room2 { get; }
        public bool IsOpen { get; } = true;
        public Door(Room room1, Room room2)
        {
            Room1 = room1;
            Room2 = room2;
        }
        public Room OtherSideFrom(Room room)
        {
            if (room == Room1) return Room2;
            if (room == Room2) return Room1;
            throw new Exception("Ошибка");
        }
        public override void Enter()
        {
            if (IsOpen)
                Console.WriteLine("Вы прошли через дверь.");
            else
                Console.WriteLine("Дверь закрыта!");
        }
    }
}
