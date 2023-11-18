using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Console_Chess
{
    internal class View
    {
        public static void printBoard(Board board)
        {
            for (int i = 0; i < board.X; i++)
            {
                Console.Write(board.RowDict[i].ToString() + ' ');
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
                Console.Write(board.ColumnDict[i].ToString() + ' ');
            }
        }
        public static void printPiece(Piece piece)
        {
            ConsoleColor aux = Console.ForegroundColor;
            if (piece.Color == Color.BLACK)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                switch (piece.ToString())
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
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                switch (piece.ToString())
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
            Console.ForegroundColor = aux;


        }
    }
}
