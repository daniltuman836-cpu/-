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
        virtual public Maze MakeMaze()
        {
            return new Maze();
        }
        virtual public Wall MakeWall()
        {
            return new Wall();
        }
        virtual public Room MakeRoom(int number)
        {
            Console.WriteLine("Создание обычной комнаты");
            return new Room(number);
        }
        virtual public Door MakeDoor(Room room1, Room room2)
        {
            return new Door(room1, room2);
        }
    }
}
