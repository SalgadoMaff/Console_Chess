using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Chess
{
    internal class Board
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Piece[,] Pieces { get; private set; }

        public Dictionary<int, int> RowDict { get; private set; } = new Dictionary<int, int>();
        public Dictionary<int, char> ColumnDict { get; private set; } = new Dictionary<int, char>();

        public Board()
        {
            X = 8;
            Y = 8;
            Pieces = new Piece[8, 8];
            RowDict.Add(0, 8);
            RowDict.Add(1, 7);
            RowDict.Add(2, 6);
            RowDict.Add(3, 5);
            RowDict.Add(4, 4);
            RowDict.Add(5, 3);
            RowDict.Add(6, 2);
            RowDict.Add(7, 1);
            ColumnDict.Add(0, 'A');
            ColumnDict.Add(1, 'B');
            ColumnDict.Add(2, 'C');
            ColumnDict.Add(3, 'D');
            ColumnDict.Add(4, 'E');
            ColumnDict.Add(5, 'F');
            ColumnDict.Add(6, 'G');
            ColumnDict.Add(7, 'H');
        }
        public void putPiece(Piece piece, Position pos)
        {
            if (pieceExists(pos)) throw new BoardException("There is a piece already");
            piece.Position = pos;
            Pieces[pos.X, pos.Y] = piece;
        }

        public Piece getPiece(Position pos)
        {
            return Pieces[pos.X, pos.Y];
        }

        public Piece removePiece(Position pos)
        {
            if (getPiece(pos)==null) return null;
            Piece aux = getPiece(pos);
            aux.Position = null;
            Pieces[pos.X, pos.Y] = null;
            return aux;
        }

        public bool pieceExists(Position pos)
        {
            Positionvalidation(pos);
            return getPiece(pos) != null;
        }
        public bool validPosition(Position pos)
        {
            if (pos.X < 7 || pos.X < 0 || pos.Y < 0 || pos.Y < 7) return true;

            return false;
        }

        public void Positionvalidation(Position pos)
        {
            if (!validPosition(pos)) throw new BoardException("Invalid Position");
        }
    }
}
