using MazeLibrary.Doors;
using MazeLibrary.Rooms;
using MazeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeLibrary.Walls;

namespace FactoryMethod
{
    public class MazeCreator
    {
        public Maze CreateMaze()
        {
            Maze maze = MakeMaze();
            Room room1 = MakeRoom(1);
            Room room2 = MakeRoom(2);
            Door door = MakeDoor(room1, room2);
            maze.AddRoom(room1);
            maze.AddRoom(room2);
            room1.SetSide(Direction.North, MakeWall());
            room1.SetSide(Direction.East, door);
            room1.SetSide(Direction.South, MakeWall());
            room1.SetSide(Direction.West, MakeWall());
            room2.SetSide(Direction.North, MakeWall());
            room2.SetSide(Direction.East, MakeWall());
            room2.SetSide(Direction.South, MakeWall());
            room2.SetSide(Direction.West, door);
            return maze;
        }
        public virtual Maze MakeMaze()
        {
            Console.WriteLine("----- Вы создали обычный лабиринт -----");
            return new Maze();
        }

        public virtual Room MakeRoom(int number)
        {
            Console.WriteLine($"Вы создали обычную комнату №{number}");
            return new Room(number);
        }

        public virtual Wall MakeWall()
        {
            return new Wall();
        }

        public virtual Door MakeDoor(Room room1, Room room2)
        {
            Console.WriteLine($"Вы создали обычную дверь между комнатами №{room1.Number} и №{room2.Number}");
            return new Door(room1, room2);
        }
    }
}
