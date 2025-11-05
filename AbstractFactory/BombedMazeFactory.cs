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
    public class BombedMazeFactory : IMazeFactory
    {
        public BombedMazeFactory() { }

        public Maze MakeMaze() => new Maze();
        public Wall MakeWall() => new BombedWall();
        public Room MakeRoom(int number) => new RoomWithBomb(number);
        public Door MakeDoor(Room room1, Room room2) => new Door(room1, room2);
    }
}
