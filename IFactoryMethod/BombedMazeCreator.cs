using MazeLibrary.Rooms;
using MazeLibrary.Walls;
using MazeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeLibrary.Doors;

namespace FactoryMethod
{
    public class BombedMazeCreator : MazeCreator
    {
        public override Maze MakeMaze()
        {
            Console.WriteLine("----- Вы создали лабиринт с бомбой -----");
            return new Maze();
        }

        public override Wall MakeWall()
        {
            return new BombedWall();
        }

        public override Room MakeRoom(int number)
        {
            Console.WriteLine($"Вы создали комнату №{number} с бомбой");
            return new RoomWithBomb(number);
        }

        public override Door MakeDoor(Room room1, Room room2)
        {
            Console.WriteLine($"Вы создали заминированную дверь между комнатами №{room1.Number} и №{room2.Number}");
            return new Door(room1, room2);
        }
    }
}
