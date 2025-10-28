using MazeLibrary.Doors;
using MazeLibrary.Rooms;
using MazeLibrary.Walls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary
{
    public class MazeGame
    {
        public Maze CreateMaze()
        {
            Maze maze = new Maze();
            Room room1 = new Room(1);
            Room room2 = new Room(2);
            Door door = new Door(room1, room2);
            maze.AddRoom(room1);
            maze.AddRoom(room2);
            room1.SetSide(Direction.North, new Wall());
            room1.SetSide(Direction.South, new Wall());
            room1.SetSide(Direction.East, door);
            room1.SetSide(Direction.West, new Wall());
            room2.SetSide(Direction.North, new Wall());
            room2.SetSide(Direction.South, new Wall());
            room2.SetSide(Direction.East, new Wall());
            room2.SetSide(Direction.West, door);
            return maze;
        }
    }
}
