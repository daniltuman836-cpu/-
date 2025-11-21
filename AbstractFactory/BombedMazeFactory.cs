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

        public override Wall MakeWall()
        {
            return new BombedWall();
        }

        public override Room MakeRoom(int number)
        {
            return new RoomWithBomb(number);
        }
    }
}
