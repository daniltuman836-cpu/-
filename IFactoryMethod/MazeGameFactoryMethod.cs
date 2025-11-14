using MazeLibrary.Doors;
using MazeLibrary.Rooms;
using MazeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class MazeGameFactoryMethod
    {
        public class MazeGame
        {
            public Maze CreateMaze(IFactoryMethod fmethod)
            {
                Maze maze = fmethod.MakeMaze();
                Room room1 = fmethod.MakeRoom(1);
                Room room2 = fmethod.MakeRoom(2);
                Door door = fmethod.MakeDoor(room1, room2);
                maze.AddRoom(room1);
                maze.AddRoom(room2);
                room1.SetSide(Direction.North, fmethod.MakeWall());
                room1.SetSide(Direction.East, door);
                room1.SetSide(Direction.South, fmethod.MakeWall());
                room1.SetSide(Direction.West, fmethod.MakeWall());
                room2.SetSide(Direction.North, fmethod.MakeWall());
                room2.SetSide(Direction.East, fmethod.MakeWall());
                room2.SetSide(Direction.South, fmethod.MakeWall());
                room2.SetSide(Direction.West, door);
                return maze;
            }
        }
    }
}
