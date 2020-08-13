using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{
    class Board
    {
        public string[] SelectedColors { get => _SelectedColors; set => _SelectedColors = value; }
        public string[,] PlayBoard { get => _PlayBoard; set => _PlayBoard = value; }

        private string[] _SelectedColors = new string[4];

        private string[,] _PlayBoard = { {"O", "O", "O", "O", "O", "O"},
                                        {"O", "O", " ", " ", " ", " "},
                                        {"-", "-", "-", "-", "-", "-"},
                                        {"O", "O", "O", "O", "O", "O"},
                                        {"O", "O", " ", " ", " ", " "},
                                        {"-", "-", "-", "-", "-", "-"},

                                        {"O", "O", "O", "O", "O", "O"},
                                        {"O", "O", " ", " ", " ", " "},
                                        {"-", "-", "-", "-", "-", "-"},

                                        {"O", "O", "O", "O", "O", "O"},
                                        {"O", "O", " ", " ", " ", " "},
                                        {"-", "-", "-", "-", "-", "-"},

                                        {"O", "O", "O", "O", "O", "O"},
                                        {"O", "O", " ", " ", " ", " "},
                                        {"-", "-", "-", "-", "-", "-"},

                                        {"O", "O", "O", "O", "O", "O"},
                                        {"O", "O", " ", " ", " ", " "},
                                        {"-", "-", "-", "-", "-", "-"},

                                        {"O", "O", "O", "O", "O", "O"},
                                        {"O", "O", " ", " ", " ", " "},
                                        {"-", "-", "-", "-", "-", "-"},

                                        {"O", "O", "O", "O", "O", "O"},
                                        {"O", "O", " ", " ", " ", " "},
                                        {"-", "-", "-", "-", "-", "-"},

                                        {"O", "O", "O", "O", "O", "O"},
                                        {"O", "O", " ", " ", " ", " "},
                                        {"-", "-", "-", "-", "-", "-"},

                                        {"O", "O", "O", "O", "O", "O"},
                                        {"O", "O", " ", " ", " ", " "},
                                     };

        public void DrawBoard()
        {
            for (int i = 0; i < SelectedColors.Length; i++)
            {
                Console.WriteLine(SelectedColors[i]);
            }

            for (int r = 0; r < PlayBoard.GetLength(0); r++)
            {
                for (int c = 0; c < PlayBoard.GetLength(1); c++)
                {
                    /*Lav bundlinje*/
                    if (c == 2) // der være spaces eller er vi ved en bundlinje
                    {
                        if ((r + 1) % 3 == 0)
                        {
                            Console.Write("---");
                        }
                        else
                        {
                            Console.Write("   ");
                        }
                        
                    }

                    if (PlayBoard[r,c] == "-")
                    {
                        Console.Write(PlayBoard[r, c] + "-");
                    }
                    else
                    {
                        Console.Write(PlayBoard[r, c] + " ");
                    }
                }
                Console.WriteLine();
           
            }

        }

    }
}
