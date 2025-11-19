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
    public class BombedMazeFactory : StandardMazeFactory
    {
        public BombedMazeFactory() { }

        override public Maze MakeMaze()
        {
            Console.WriteLine("----- Вы создали лабиринт с бомбой -----");
            return new Maze();
        }

        override public Wall MakeWall()
        {
            return new BombedWall();
        }

        override public Room MakeRoom(int number)
        {
            return new RoomWithBomb(number);
        }

        override public Door MakeDoor(Room room1, Room room2)
        {
            return new Door(room1, room2);
        }
    }
}
