using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Console_Chess
{
    internal class View
    {
        public static void printBoard(Board board, PosDict posdict, bool[,] possiblePositions)
        {
            ConsoleColor originalBG = Console.BackgroundColor;
            ConsoleColor newBG = ConsoleColor.DarkGray;

            for (int i = 0; i < board.X; i++)
            {
                Console.Write(posdict.RowDict[i].ToString() + ' ');
                for (int j = 0; j < board.Y; j++)
                {

                    if (possiblePositions[i, j])
                    {
                        Console.BackgroundColor = newBG;
                    }
                    else
                    {
                        Console.BackgroundColor = originalBG;
                    }

                    printPiece(board.Pieces[i, j]);

                }
                Console.BackgroundColor = originalBG;
                Console.WriteLine();

            }
            Console.Write("  ");
            for (int i = 0; i < board.Y; i++)
            {
                Console.Write(posdict.ColumnDict[i].ToString() + ' ');
            }
            Console.WriteLine();
        }
        public static void printPiece(Piece piece)
        {
            if (piece is not null)
            {
                ConsoleColor aux = Console.ForegroundColor;
                if (piece.Color == Color.BLACK)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    printLetters(piece.ToString());
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    printLetters(piece.ToString());
                }
                Console.ForegroundColor = aux;
                Console.Write(' ');
            }
            else
            {
                Console.Write("- ");
            }

        }
        public static void printLetters(string s)
        {
            switch (s)
            {
                case "KING":
                    Console.Write('K');
                    break;
                case "QUEEN":
                    Console.Write('Q');
                    break;
                case "ROOK":
                    Console.Write('R');
                    break;
                case "BISHOP":
                    Console.Write('B');
                    break;
                case "KNIGHT":
                    Console.Write('H');
                    break;
                case "PAWN":
                    Console.Write('P');
                    break;
                default:
                    break;
            }
        }
        public static Position readChessPosition(PosDict posdict)
        {
            Console.Write("Enter a Position (EX = A1): ");
            string s = Console.ReadLine().ToUpper();
            char ch = s[0];
            int i = int.Parse(s[1].ToString());
            return posdict.toPosition(ch, i);

        }

        internal static void printBoard(Board board, PosDict posdict)
        {
            for (int i = 0; i < board.X; i++)
            {
                Console.Write(posdict.RowDict[i].ToString() + ' ');
                for (int j = 0; j < board.Y; j++)
                {

                    printPiece(board.Pieces[i, j]);

                }
                Console.WriteLine();

            }
            Console.Write("  ");
            for (int i = 0; i < board.Y; i++)
            {
                Console.Write(posdict.ColumnDict[i].ToString() + ' ');
            }
            Console.WriteLine();
        }
    }
}
