using MazeLibrary.Rooms;
namespace MazeLibrary
{
    public class Maze
    {
        public Maze() { }

        public Maze(Maze otherMaze)
        {
            foreach (var room in otherMaze._rooms)
            {
                _rooms.Add((Room)room.Clone());
            }
        }

        public Maze Clone()
        {
            return new Maze(this);
        }

        private List<Room> _rooms = new List<Room>();

        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }
        public Room RoomNo(int number)
        {
            var room = _rooms.FirstOrDefault(r => r.Number == number) ?? throw new ArgumentException($"Комната №{number} не найдена");
            Console.WriteLine($"Комната под номером {number} найдена");
            return room;
        }
        public IEnumerable<Room> Rooms => _rooms;
    }
}
