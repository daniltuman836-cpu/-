using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Rooms
{
    public class Room : MapSite
    {
        public int Number { get; }
        private MapSite[] _sides = new MapSite[4];

        public Room(int roomNo)
        {
            Number = roomNo;
        }

        public void SetSide(Direction dir, MapSite site)
        {
            _sides[(int)dir] = site;
        }
        public MapSite GetSide(Direction dir)
        {
            return _sides[(int)dir];
        }
        public override void Enter()
        {
            Console.WriteLine($"Вы вошли в комнату {Number}");
        }

    }
}
