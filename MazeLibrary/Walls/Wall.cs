using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Walls
{
    public class Wall : MapSite
    {
        public override void Enter()
        {
            Console.WriteLine("Вы врезались в обычную стену.");
        }
        public override string ToString() => "Wall";
    }
}
