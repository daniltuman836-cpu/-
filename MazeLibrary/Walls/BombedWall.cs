using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Walls
{
    public class BombedWall : Wall
    {
        private bool _bomb;

        public BombedWall(BombedWall otherBombedWall)
        {
            _bomb = otherBombedWall._bomb;
        }

        public BombedWall() { }

        public override Wall Clone()
        {
            Console.WriteLine("Вы клонировали стену с бомбой");
            return new BombedWall(this);
        }

        public override void Enter()
        {
            Console.WriteLine("Вы врезались в стену с бомбой");
        }
    }
}
