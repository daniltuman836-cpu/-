using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Walls
{
    public class BombedWall : Wall
    {
        public override void Enter()
        {
            Console.WriteLine("Вы врезались в стену с бомбой");
        }
        public override string ToString() => "BombedWall";
    }
}
