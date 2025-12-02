using AbstractFactory;
using MazeLibrary.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeSingleton
{
    class ProgramSingleton
    {
        static void Main(string[] args)
        {
            MazeGame game = new MazeGame();
            IMazeFactory maze = MazeSingleton.Instance();
            game.CreateMaze(maze);
            IMazeFactory mazeSingletonTwo = MazeSingleton.Instance();
        }
    }
}