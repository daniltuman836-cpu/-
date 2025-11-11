using MazeLibrary;
using MazeLibrary.Rooms;
using MazeLibrary.Doors;
using MazeLibrary.Walls;
namespace FactoryMethod
{
    public interface IFactoryMethod
    {
        virtual Maze MakeMaze()
        { return new Maze(); }
        virtual Wall MakeWall()
        { return new Wall(); }
        virtual Room MakeRoom(int number)
        { return new Room(number); }
        virtual Door MakeDoor(Room room1, Room room2)
        { return new Door(room1, room2); }
    }
}
