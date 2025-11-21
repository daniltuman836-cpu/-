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
        public virtual Maze MakeMaze()
        {
            return new Maze();
        }

        public virtual Wall MakeWall()
        {
            return new Wall();
        }

        public virtual Room MakeRoom(int number)
        {
            Console.WriteLine("Создание обычной комнаты");
            return new Room(number);
        }

        public virtual Door MakeDoor(Room room1, Room room2)
        {
            return new Door(room1, room2);
        }
    }
}
