using MazeLibrary;
using MazeLibrary.Rooms;
using MazeLibrary.Doors;
using MazeLibrary.Walls;

namespace Builder
{
    public interface IMazeBuilder
    {
        public virtual void BuildMaze() { }
        public virtual void BuildRoom(int room) { }
        public virtual void BuildDoor(int roomFrom, int roomTo) { }
        
    }
}
