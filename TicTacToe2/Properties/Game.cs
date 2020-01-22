using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TicTacToe2
{
    public static class Game
    {
        private static UInt16[] XGrid = new UInt16[9];
        private static UInt16[] OGrid = new UInt16[9];

        public static Boolean playerTurn; //True = X, False = O
        public static UInt16 turn;

        public static Boolean endGame = false;
        public static Boolean draw = false;

        public static UInt16[] winners = new UInt16[3];

        public static Player oPlayer = new Player();
        public static Player xPlayer = new Player();


        public static void Home()
        {
            
        }

        public static void Playing()
        {
            endGame = false;
            draw = false;
            Game.turn = 0;
            Array.Clear(winners, 0, 3);
            Array.Clear(XGrid, 0, 9);
            Array.Clear(OGrid, 0, 9);
            oPlayer.score = 0;
            xPlayer.score = 0;
        }

        public static void Winner(UInt16 placeOne, UInt16 placeTwo, UInt16 placeThree)
        {
            //ChangeTurn();

            winners[0] = placeOne;
            winners[1] = placeTwo;
            winners[2] = placeThree;

            if (playerTurn)
                xPlayer.score++;
            else
                oPlayer.score++;

            endGame = true;
        }

        public static void Draw()
        {
            draw = true;
            endGame = true;
        }

        public static void Reset()
        {
            ChangeTurn();
            endGame = false;
            draw = false;
            Game.turn = 0;
            Array.Clear(winners, 0, 3);
            Array.Clear(XGrid, 0, 9);
            Array.Clear(OGrid, 0, 9);
        }

        public static void SelectPlace(UInt16 place)
        {
            if (playerTurn)
            {
                XGrid[place] = 1;
            }
            else
            {
                OGrid[place] = 1;
            }

            if (turn > 3)
            {
                if (XGrid[0] + XGrid[3] + XGrid[6] == 3)
                {
                    Winner(0, 3, 6);
                    return;
                }
                else if (XGrid[1] + XGrid[4] + XGrid[7] == 3)
                {
                    Winner(1, 4, 7);
                    return;
                }
                else if (XGrid[2] + XGrid[5] + XGrid[8] == 3)
                {
                    Winner(2, 5, 8);
                    return;
                }
                else if (XGrid[0] + XGrid[1] + XGrid[2] == 3)
                {
                    Winner(0, 1, 2);
                    return;
                }
                else if (XGrid[3] + XGrid[4] + XGrid[5] == 3)
                {
                    Winner(3, 4, 5);
                    return;
                }
                else if (XGrid[6] + XGrid[7] + XGrid[8] == 3)
                {
                    Winner(6, 7, 8);
                }
                else if (XGrid[0] + XGrid[4] + XGrid[8] == 3)
                {
                    Winner(0, 4, 8);
                    return;
                }
                else if (XGrid[2] + XGrid[4] + XGrid[6] == 3)
                {
                    Winner(2, 4, 6);
                    return;
                }

                if (OGrid[0] + OGrid[3] + OGrid[6] == 3)
                {
                    Winner(0, 3, 6);
                    return;
                }
                else if (OGrid[1] + OGrid[4] + OGrid[7] == 3)
                {
                    Winner(1, 4, 7);
                    return;
                }
                else if (OGrid[2] + OGrid[5] + OGrid[8] == 3)
                {
                    Winner(2, 5, 8);
                    return;
                }
                else if (OGrid[0] + OGrid[1] + OGrid[2] == 3)
                {
                    Winner(0, 1, 2);
                    return;
                }
                else if (OGrid[3] + OGrid[4] + OGrid[5] == 3)
                {
                    Winner(3, 4, 5);
                    return;
                }
                else if (OGrid[6] + OGrid[7] + OGrid[8] == 3)
                {
                    Winner(6, 7, 8);
                    return;
                }
                else if (OGrid[0] + OGrid[4] + OGrid[8] == 3)
                {
                    Winner(0, 4, 8);
                    return;
                }
                else if (OGrid[2] + OGrid[4] + OGrid[6] == 3)
                {
                    Winner(2, 4, 6);
                    return;
                }
            }

            ChangeTurn();

            if (turn == 8 && !endGame)
            {
                Draw();
            }
        }

        public static void ChangeTurn()
        {
            playerTurn = !playerTurn;
        }

    }
}


