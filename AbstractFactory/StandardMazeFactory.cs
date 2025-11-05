using MazeLibrary.Walls;
using MazeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeLibrary.Rooms;
using MazeLibrary.Doors;
namespace AbstractFactory
{
    public class StandardMazeFactory : IMazeFactory
    {
        public Maze MakeMaze()
        {
            return new Maze();
        }
        public Wall MakeWall() => new Wall();
        public Room MakeRoom(int number)
        {
            Console.WriteLine("Создание обычной комнаты");
            return new Room(number);
        }
        public  Door MakeDoor(Room room1, Room room2) => new Door(room1, room2);
    }
}
