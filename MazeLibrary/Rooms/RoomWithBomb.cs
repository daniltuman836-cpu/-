using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Rooms
{
    public class RoomWithBomb : Room
    {
        public RoomWithBomb(int no) : base(no) { }

        public override void Enter()
        {
            Console.WriteLine($"Вы вошли в комнату {Number} — здесь бомба!");
        }
    }
}
