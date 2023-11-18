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
        public static void printBoard(Board board,PosDict dict)
        {
            for (int i = 0; i < board.X; i++)
            {
                Console.Write(dict.RowDict[i].ToString() + ' ');
                for (int j = 0; j < board.Y; j++)
                {

                    if (board.Pieces[i, j] is not null)
                    {
                        printPiece(board.Pieces[i, j]);
                        Console.Write(' ');
                    }
                    else
                    {
                        Console.Write("- ");
                    }

                }
                Console.WriteLine();
            }
            Console.Write("  ");
            for (int i = 0; i < board.Y; i++)
            {
                Console.Write(dict.ColumnDict[i].ToString() + ' ');
            }
            Console.WriteLine();
        }
        public static void printPiece(Piece piece)
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
            return posdict.toPosition(ch,i);

        }
    }
}
