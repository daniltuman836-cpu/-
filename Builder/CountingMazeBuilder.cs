using MazeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CountingMazeBuilder
    {
        private int _rooms;
        private int _doors;
        private Maze _curentmaze;
        public CountingMazeBuilder() { }
        public void BuildMaze()
        {
            _rooms = 0;
            _doors = 0;
        }

        public void BuildRoom(int room)
        {
            _rooms++;
        }

        public void BuildDoor(int roomFrom, int roomTo)
        {
            _doors++;
        }

        public void GetCounts(out int rooms, out int doors)
        {
            rooms = _rooms;
            doors = _doors;
        }
        public void AddWall(int number, Direction dir) { }
        public Maze GetMaze()
        {
            return _curentmaze;
        }
    }
}
