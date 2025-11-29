using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Rooms
{
    public class RoomWithBomb : Room
    {
        public RoomWithBomb(int number) : base(number) { }

        public RoomWithBomb(RoomWithBomb otherRoom) : base(otherRoom) { }

        public override Room Clone()
        {
            Console.WriteLine("Вы клонировали комнату с бомбой");
            return new RoomWithBomb(this);
        }

        public override void Enter()
        {
            Console.WriteLine($"Вы вошли в комнату {Number} — здесь бомба!");
        }
    }
}
