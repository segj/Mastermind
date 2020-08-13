using System;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            Board b = new Board();
            AiPlayer ai = new AiPlayer();

            ai.SelectColors();
            b.DrawBoard();

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ");
            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();
            Console.ReadKey();
        }
    }
}
