using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{
    class HumanPlayer
    {

        public void SelectColors(string colors, int turn)
        {
            
            int  row = turn * 2;   

            int color = 0;
            for (int c = 0; c < Board.PlayBoard.GetLength(1); c++)
            {

                    if (Board.PlayBoard[row, c] == Board.BP.P)
                    {

                        switch (colors.Substring(color,1))
                        {
                            case "R":
                                Board.PlayBoard[row, c] = Board.BP.Red;
                                break;
                            case "B":
                                Board.PlayBoard[row, c] = Board.BP.Blue;
                                break;
                            case "Ø":
                                Board.PlayBoard[row, c] = Board.BP.Green;
                                break;
                            case "H":
                                Board.PlayBoard[row, c] = Board.BP.White;
                                break;
                            case "G":
                                Board.PlayBoard[row, c] = Board.BP.Yellow;
                                break;
                            default:
                                break;
                        }
                        
                    color++;
                    }
            }
            
        }

    }
}
