using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{
    class Game
    {
        public int NumberOfTurns { get; private set; }
        public int Turn { get; set; }
        public bool Win { get; set; }
        public Game()
        {
            NumberOfTurns = 10;
            Turn = 1;
        }

        public bool GameOver()
        {
            return Turn > NumberOfTurns || Win;
        }

        public void NewGame()
        {
            Board b = new Board();
            AiPlayer ai = new AiPlayer();
            HumanPlayer hp = new HumanPlayer();
            ai.SelectColors();
            b.DrawBoard(Board.PlayBoard_Copy);
            //b.DrawResultBoard();

            while (!GameOver())
            {
                Console.WriteLine("Indtast 4 valg: (R)ød, (B)lå, (H)vid, (G)ul g(Ø)rn - Eksempel RGHØ");
                hp.SelectColors(Console.ReadLine(), Turn);
                Console.Clear();

                Win = ai.ValidateResult(Turn);
                b.DrawBoard(Board.PlayBoard);

                Turn++;
               

            }
            b.DrawResultBoard();
            if (Win)
            {
                Console.WriteLine($"Du vandt!! i {Turn} omgange");
            }
            else
            {
                Console.WriteLine("Du vandt ikke!!");
            }
            Console.ReadKey();

        }
    }
}
