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

        

        public Board()
        {
            X = 8;
            Y = 8;
            Pieces = new Piece[8, 8];
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
            PositionValidation(pos);
            return getPiece(pos) != null;
        }
        public bool validPosition(Position pos)
        {
            if (pos.X < 8 && pos.X > -1 && pos.Y > -1 && pos.Y < 8) return true;

            return false;
        }

        public void PositionValidation(Position pos)
        {
            if (!validPosition(pos)) throw new BoardException("Invalid Position");
        }
    }
}
