using MazeLibrary.Doors;
using MazeLibrary.Rooms;
using MazeLibrary.Walls;
using MazeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class EnchantedMazeFactory : StandardMazeFactory
    {
        public EnchantedMazeFactory() { }

        public override Room MakeRoom(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            Console.WriteLine("Создание магической комнаты");
            return new EnchantedRoom(number);
        }

        public override Door MakeDoor(Room room1, Room room2)
        {
            return new EnchantedDoor(room1, room2);
        }

        public override Wall MakeWall()
        {
            return new Wall();
        }
    }
}
