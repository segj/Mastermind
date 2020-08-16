using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Mastermind
{
    class AiPlayer
    {
        public int[] Markpos { get; set; }

        public void SelectColors()
        {
            Random rnd = new Random();


            for (int r = 0; r < Board.ResultBoard.GetLength(0); r++)
            {
                for (int c = 0; c < Board.ResultBoard.GetLength(1); c++)
                {

                    if (Board.ResultBoard[r, c] == Board.BP.P)
                    {

                        switch (rnd.Next(4))
                        {
                            case 0:
                                Board.ResultBoard[r, c] = Board.BP.Red;
                                break;
                            case 1:
                                Board.ResultBoard[r, c] = Board.BP.Blue;
                                break;
                            case 2:
                                Board.ResultBoard[r, c] = Board.BP.Green;
                                break;
                            case 3:
                                Board.ResultBoard[r, c] = Board.BP.White;
                                break;
                            case 4:
                                Board.ResultBoard[r, c] = Board.BP.Yellow;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }


        public bool ValidateResult(int turn)
        {
            bool okColor = false;
            bool okPos = false;
            bool colorFound = false;
            bool win = false;
            int numberOfOkPos = 0;
            
            int row = turn * 2;

            int ResultPosCol = 1; //Pos i de 4 resultatfelter
            int ResultPosRow = row - 1; //Pos i de 4 resultatfelter

            //Traveser kollonner for spillebrædtet*/
            for (int c = 10; c < Board.PlayBoard.GetLength(1); c++)
            {
                //Søg relevante farver
                if (Board.PlayBoard[row, c] == Board.BP.Blue ||
                    Board.PlayBoard[row, c] == Board.BP.Green ||
                    Board.PlayBoard[row, c] == Board.BP.Red ||
                    Board.PlayBoard[row, c] == Board.BP.White ||
                    Board.PlayBoard[row, c] == Board.BP.Yellow)
                {
                    //Traverser resultattabellen
                    for (int c2 = 0; c2 < Board.ResultBoard.GetLength(1); c2++)
                    {
                        if (Board.ResultBoard[1, c2] == Board.BP.Blue ||
                            Board.ResultBoard[1, c2] == Board.BP.Green ||
                            Board.ResultBoard[1, c2] == Board.BP.Red ||
                            Board.ResultBoard[1, c2] == Board.BP.White ||
                            Board.ResultBoard[1, c2] == Board.BP.Yellow)
                        {
                            colorFound = true;
                            okPos = false; okColor = false;


                            /*Farverne er ens - OBS Vi ved at der er en farve i begge boards på denne pos*/
                            if (Board.ResultBoard[1, c2] == Board.PlayBoard[row, c] || c2 >= Board.ResultBoard.GetLength(1)/*Sikre at vi når enden i alle tilfælde*/)
                            {

                                if ((c - 9) > 4)
                                {
                                    ResultPosRow = row;
                                    ResultPosCol = c - 15;
                                }
                                else
                                {
                                    ResultPosRow = row - 1;
                                    ResultPosCol = c - 9;
                                }

                                /*Er pos i player og resultboard også den samme.*/
                                if (c == c2)
                                {
                                    okPos = true;
                                    numberOfOkPos++;
                                    Board.PlayBoard[(ResultPosRow), ResultPosCol] = Board.BP.HitPos;
                                    //Console.WriteLine("Samme Pos og Farve");
                                    break; //Der er hit ud.
                                }
                                else /*Pos var ikke den sammen, men kun farven var ens*/
                                {
                                    okColor = true;
                                    Board.PlayBoard[(ResultPosRow), ResultPosCol] = Board.BP.HitColor;
                                    //Console.WriteLine("Samme Farve");
                                }

                            }
                        }
                    }

                    if (!okColor && !okPos && colorFound)
                    {
                        if ((c - 9) > 4)
                        {
                            ResultPosRow = row;
                            ResultPosCol = c - 15;
                        }
                        else
                        {
                            ResultPosRow = row - 1;
                            ResultPosCol = c - 9;
                        }

                        /*Traverser og se om harven findes i det hele taget*/
                        //Console.WriteLine("Farve ikke fundet");
                        colorFound = false;
                    }
                }
            }
            if (numberOfOkPos == 4)
            {
                win = true;
            }
            return win;
                
        }
    }
}
