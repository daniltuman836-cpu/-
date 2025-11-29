using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary.Rooms
{
    public class Room : IMapSite
    {
        public int Number { get; private set; }
        private IMapSite[] _sides = new IMapSite[4];

        public Room(int roomNo)
        {
            Number = roomNo;
        }
        public Room(Room r1)
        {
            Number = r1.Number;
            _sides = new IMapSite[4];
            for (int i = 0; i < 4; i++)
            {
                _sides[i] = r1._sides[i].Clone();
            }
        }

        public void SetSide(Direction dir, IMapSite site)
        {
            _sides[(int)dir] = site;
        }
        public IMapSite GetSide(Direction dir)
        {
            return _sides[(int)dir];
        }

        public virtual IMapSite Clone()
        {
            Console.WriteLine("Вы клонировали обычную комнату");
            return new Room(this);
        }

        public void Initialize(int number)
        {
            Console.WriteLine($"Вы изменили № комнаты на {number}");
            Number = number;
        }

        public virtual void Enter()
        {
            Console.WriteLine($"Вы вошли в комнату {Number}");
        }
    }
}
