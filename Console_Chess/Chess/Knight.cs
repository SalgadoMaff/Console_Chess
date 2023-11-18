using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Chess
{
    internal class Knight : Piece
    {
        public Knight(Color color, Board board) : base(color, board)
        {
        }

        public override bool canMove(Position pos)
        {
            Piece p = Board.getPiece(pos);
            if (p == null)
            {
                return true;
            }
            else
            {
                if (p.Color != this.Color)
                {
                    return true;
                }
            }
            return false;
        }

        public override bool[,] possibleMovements()
        {
            bool[,] mat = new bool[this.Board.X, this.Board.Y];
            //up right
            Position pos = new Position(this.Position.X - 2, this.Position.Y + 1);
            if (this.Board.getPiece(pos) != null && this.Board.getPiece(pos).Color != this.Color)
            {
                mat[pos.X, pos.Y] = true;

            }
            //up left
            pos.X = this.Position.X - 2;
            pos.Y = this.Position.Y - 1;
            if (this.Board.getPiece(pos) != null && this.Board.getPiece(pos).Color != this.Color)
            {
                mat[pos.X, pos.Y] = true;

            }
            //left up
            pos.X = this.Position.X - 1;
            pos.Y = this.Position.Y - 2;
            if (this.Board.getPiece(pos) != null && this.Board.getPiece(pos).Color != this.Color)
            {
                mat[pos.X, pos.Y] = true;

            }
            //left down
            pos.X = this.Position.X + 1;
            pos.Y = this.Position.Y - 2;
            if (this.Board.getPiece(pos) != null && this.Board.getPiece(pos).Color != this.Color)
            {
                mat[pos.X, pos.Y] = true;

            }
            //right up
            pos.X = this.Position.X - 1;
            pos.Y = this.Position.Y + 2;
            if (this.Board.getPiece(pos) != null && this.Board.getPiece(pos).Color != this.Color)
            {
                mat[pos.X, pos.Y] = true;

            }
            //right down
            pos.X = this.Position.X + 1;
            pos.Y = this.Position.Y + 2;
            if (this.Board.getPiece(pos) != null && this.Board.getPiece(pos).Color != this.Color)
            {
                mat[pos.X, pos.Y] = true;

            }
            //down right
            pos.X = this.Position.X + 2;
            pos.Y = this.Position.Y + 1;
            if (this.Board.getPiece(pos) != null && this.Board.getPiece(pos).Color != this.Color)
            {
                mat[pos.X, pos.Y] = true;

            }
            //down left
            pos.X = this.Position.X + 2;
            pos.Y = this.Position.Y - 1;
            if (this.Board.getPiece(pos) != null && this.Board.getPiece(pos).Color != this.Color)
            {
                mat[pos.X, pos.Y] = true;

            }



            return mat;
        }

        public override string ToString()
        {
            return "KNIGHT";
        }
    }
}
