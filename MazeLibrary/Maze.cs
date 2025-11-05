using MazeLibrary.Rooms;
namespace MazeLibrary
{
    public class Maze
    {
        private Dictionary<int, Room> rooms = new Dictionary<int, Room>();

    public void AddRoom(Room room) => rooms[room.Number] = room;

        public Room RoomNo(int number)
        {
            rooms.TryGetValue(number, out var room);

            return room;
        }
        public IEnumerable<Room> Rooms => rooms.Values;
    }
}
