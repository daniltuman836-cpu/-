using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProgramAF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new MazeGame();
            IMazeFactory standardFactory = new StandardMazeFactory();
            Maze standardMaze = game.CreateMaze(standardFactory);
            foreach (var room in standardMaze.Rooms)
            {
                Console.WriteLine(room);
            }
            Console.WriteLine();
            IMazeFactory bombedFactory = new BombedMazeFactory();
            Maze bombedMaze = game.CreateMaze(bombedFactory);
            foreach (var room in bombedMaze.Rooms)
            {
                Console.WriteLine(room);
            }
            Console.ReadLine();

        }
    }
}
