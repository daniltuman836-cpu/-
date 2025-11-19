using MazeLibrary.Rooms;
using MazeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeLibrary.Doors;
using MazeLibrary.Walls;

namespace Builder
{
    public class StandardMazeBuilder : IMazeBuilder
    {
        private Maze _currentMaze = null;
        public StandardMazeBuilder() { }
        
        public void BuildMaze()
        {
            _currentMaze = new Maze();
        }
        public Maze GetMaze()
        {
            return _currentMaze;
        }

        public void BuildRoom(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Номер комнаты должен быть натуральным числом");
            }
            Room room = new Room(number);
            _currentMaze.AddRoom(room);

            room.SetSide(Direction.North, new Wall());
            room.SetSide(Direction.South, new Wall());
            room.SetSide(Direction.East, new Wall());
            room.SetSide(Direction.West, new Wall());
        }
        public void BuildDoor(int number1, int number2)
        {
            Room room1 = _currentMaze.RoomNo(number1);
            Room room2 = _currentMaze.RoomNo(number2);
            Door door = new Door(room1, room2);
            room1.SetSide(CommonWall(room1, room2), door);
            room1.SetSide(CommonWall(room1, room2), door);
        }
        private Direction CommonWall(Room room1, Room room2)
        {
            return Direction.North;
        }
    }
}
