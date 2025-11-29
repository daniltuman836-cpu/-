using MazeLibrary.Rooms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Doors
{
    public class Door : IMapSite
    {
        private Room _room1;
        private Room _room2;
        private bool IsOpen { get; } = true;

        public Door(Room room1, Room room2)
        {
            _room1 = room1;
            _room2 = room2;
        }

        public Door(Door otherDoor)
        {
            _room1 = (Room)otherDoor._room1.Clone();
            _room2 = (Room)otherDoor._room2.Clone();
            IsOpen = true;
        }

        public virtual IMapSite Clone()
        {
            Console.WriteLine("Вы клонировали обычную дверь");
            return new Door(this);
        }

        public void Initialize(Room room1, Room room2)
        {
            Console.WriteLine($"Вы изменили комнаты, между которыми находится дверь на комнату №{room1.Number} и комнату №{room2.Number}");
            _room1 = room1;
            _room2 = room2;
        }

        public void Enter()
        {
            if (IsOpen)
            {
                EnterIsOpen(_room1, _room2);
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
