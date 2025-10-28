using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeLibrary;

namespace Builder
{
    public class MazeGameBuilder
    {
        public void CreateMaze(IMazeBuilder builder)
        {
            builder.BuildMaze();
            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1, 2);
        }
    }
}
