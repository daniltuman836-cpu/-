using MazeLibrary;
using MazeLibrary.Rooms;
using MazeLibrary.Doors;
using MazeLibrary.Walls;

namespace Builder
{
    public interface IMazeBuilder
    {
         void BuildMaze() { }
         void BuildRoom(int room) { }
         void BuildDoor(int roomFrom, int roomTo) { }
        
    }
}
