using MazeLibrary.Doors;
using MazeLibrary.Rooms;
using MazeLibrary.Walls;
using MazeLibrary;
using AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazePrototype
{
    class ProgramPrototype
    {
        static void Main(string[] args)
        {
            MazeGame game = new MazeGame();
            MazePrototype standartMazeFactory = new MazePrototype(new Maze(), new Wall(), new Room(5), new Door(new Room(3), new Room(11)));
            Maze maze = game.CreateMaze(standartMazeFactory);
            MazePrototype bombedMazeFactory = new MazePrototype(new Maze(), new BombedWall(), new RoomWithBomb(8), new Door(new RoomWithBomb(2), new RoomWithBomb(10)));
            Maze bombedmaze = game.CreateMaze(bombedMazeFactory);
            MazePrototype enchantedMazeFactory = new MazePrototype(new Maze(), new Wall(), new EnchantedRoom(13), new EnchantedDoor(new EnchantedRoom(7), new EnchantedRoom(9)));
            Maze enchantedmaze = game.CreateMaze(enchantedMazeFactory);
        }
    }
}
