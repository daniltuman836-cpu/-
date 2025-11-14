using MazeLibrary;
using MazeLibrary.Rooms;
using MazeLibrary.Doors;
using MazeLibrary.Walls;

namespace Builder
{
    public interface IMazeBuilder
    {
         virtual void BuildMaze() { }
         virtual void BuildRoom(int room) { }
         virtual void BuildDoor(int roomFrom, int roomTo) { }
        
    }
}
