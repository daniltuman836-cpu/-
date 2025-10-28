using System;
using System.Collections.Generic;
namespace Program
{
   
    class Program
    {
        static void Main()
        {
            MazeGame game = new MazeGameFactory();
            Console.WriteLine("Обычный лабиринт");
            MazeFactory standardFactory = new StandardMazeFactory();
            Maze standardMaze = game.CreateMaze(standardFactory);
            foreach (var room in standardMaze.Rooms)
            {
                Console.WriteLine(room);
            }
            Console.WriteLine();
            Console.WriteLine("Заминированный лаберинт");
            MazeFactory bombedFactory = new BombedMazeFactory();
            Maze bombedMaze = game.CreateMaze(bombedFactory);
            foreach (var room in bombedMaze.Rooms)
            {
                Console.WriteLine(room);
            }
            Console.ReadLine();
        }
    }
}
