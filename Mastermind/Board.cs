using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{
    class Board
    {
            
        public enum BP //Boardparts
        {
            Red = 1,
            Blue,
            Green,
            White,
            Yellow,
            HitPos,
            HitColor,
            V, //Vertikal linie
            H, //Horizontal linie
            S, //Space
            R, //Resultatfelt
            P  //Spillerfelt
        };

        public static BP[,] PlayBoard_Copy { get => _PlayBoard_Copy; set => _PlayBoard_Copy = value; }
        public static BP[,] PlayBoard { get => _PlayBoard; set => _PlayBoard = value; }
        public static BP[,] ResultBoard { get => _ResultBoard; set => _ResultBoard = value; }


        private static BP[,] _PlayBoard_Copy;
        private static BP[,] _PlayBoard = {  {BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H, },
                                        {BP.V,BP.R,BP.V,BP.V,BP.R,BP.V,BP.S,BP.S,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.V, },
                                        {BP.V,BP.R,BP.V,BP.V,BP.R,BP.V,BP.S,BP.S,BP.S,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V  },
                                        {BP.V,BP.R,BP.V,BP.V,BP.R,BP.V,BP.S,BP.S,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.V, },
                                        {BP.V,BP.R,BP.V,BP.V,BP.R,BP.V,BP.S,BP.S,BP.S,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V  },
                                        {BP.V,BP.R,BP.V,BP.V,BP.R,BP.V,BP.S,BP.S,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.V, },
                                        {BP.V,BP.R,BP.V,BP.V,BP.R,BP.V,BP.S,BP.S,BP.S,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V  },
                                        {BP.V,BP.R,BP.V,BP.V,BP.R,BP.V,BP.S,BP.S,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.V, },
                                        {BP.V,BP.R,BP.V,BP.V,BP.R,BP.V,BP.S,BP.S,BP.S,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V  },
                                        {BP.V,BP.R,BP.V,BP.V,BP.R,BP.V,BP.S,BP.S,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.V, },
                                        {BP.V,BP.R,BP.V,BP.V,BP.R,BP.V,BP.S,BP.S,BP.S,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V  },
                                        {BP.V,BP.R,BP.V,BP.V,BP.R,BP.V,BP.S,BP.S,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.V, },
                                        {BP.V,BP.R,BP.V,BP.V,BP.R,BP.V,BP.S,BP.S,BP.S,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V  },
                                        {BP.V,BP.R,BP.V,BP.V,BP.R,BP.V,BP.S,BP.S,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.V, },
                                        {BP.V,BP.R,BP.V,BP.V,BP.R,BP.V,BP.S,BP.S,BP.S,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V  },
                                        {BP.V,BP.R,BP.V,BP.V,BP.R,BP.V,BP.S,BP.S,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.V, },
                                        {BP.V,BP.R,BP.V,BP.V,BP.R,BP.V,BP.S,BP.S,BP.S,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V  },
                                        {BP.V,BP.R,BP.V,BP.V,BP.R,BP.V,BP.S,BP.S,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.V, },
                                        {BP.V,BP.R,BP.V,BP.V,BP.R,BP.V,BP.S,BP.S,BP.S,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V  },
                                        {BP.V,BP.R,BP.V,BP.V,BP.R,BP.V,BP.S,BP.S,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.V, },
                                        {BP.V,BP.R,BP.V,BP.V,BP.R,BP.V,BP.S,BP.S,BP.S,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V  },
                                        {BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.H,BP.V, },
                                   };

        private static BP[,] _ResultBoard = {  {BP.S,BP.S,BP.S,BP.S,BP.S,BP.S,BP.S,BP.S,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.S,BP.H,BP.S,BP.S, },
                                        {BP.S,BP.S,BP.S,BP.S,BP.S,BP.S,BP.S,BP.S,BP.S,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.V,BP.P,BP.V,BP.S, },
                                   };

        public Board()
        {
            PlayBoard_Copy = _PlayBoard;
        }

        public void DrawBoard(BP[,] PlayBoard)
        {
           // Console.Clear();
            for (int r = 0; r < PlayBoard.GetLength(0); r++)
            {
                for (int c = 0; c < PlayBoard.GetLength(1); c++)
                {
                    switch (PlayBoard[r,c])
                    {
                        case BP.Red:
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(" ");
                            Console.ResetColor();
                            break;
                        case BP.Blue:
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write(" ");
                            Console.ResetColor();
                            break;
                        case BP.Green:
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Write(" ");
                            Console.ResetColor();
                            break;
                        case BP.White:
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(" ");
                            Console.ResetColor();
                            break;
                        case BP.Yellow:
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.Write(" ");
                            Console.ResetColor();
                            break;
                        case BP.HitPos:
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.Write("¤");
                            Console.ResetColor();
                            break;
                        case BP.HitColor:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("¤");
                            Console.ResetColor();
                            break;
                        case BP.V:
                            Console.Write("|");
                            break;
                        case BP.H:
                            Console.Write("_");
                            break;
                        case BP.P:
                            Console.Write("_");
                            break;
                        case BP.R:
                            Console.Write("_");
                            break;
                        case BP.S:
                            Console.Write(" ");
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine();
           
            }

        }

        public void DrawResultBoard()
        {
          
            Console.WriteLine();
            Console.WriteLine();
            for (int r = 0; r < ResultBoard.GetLength(0); r++)
            {
                for (int c = 0; c < ResultBoard.GetLength(1); c++)
                {
                    switch (ResultBoard[r, c])
                    {
                        case BP.Red:
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(" ");
                            Console.ResetColor();
                            break;
                        case BP.Blue:
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write(" ");
                            Console.ResetColor();
                            break;
                        case BP.Green:
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Write(" ");
                            Console.ResetColor();
                            break;
                        case BP.White:
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(" ");
                            Console.ResetColor();
                            break;
                        case BP.Yellow:
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.Write(" ");
                            Console.ResetColor();
                            break;
                        case BP.V:
                            Console.Write("|");
                            break;
                        case BP.H:
                            Console.Write("_");
                            break;
                        case BP.S:
                            Console.Write(" ");
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine();

            }

        }

    }
}
