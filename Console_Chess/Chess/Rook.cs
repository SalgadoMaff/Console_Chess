using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Chess
{
    internal class Rook : Piece
    {
        public Rook(Color color, Board board) : base(color, board)
        {
        }

        public override bool canMove(Position pos)
        {
            Piece p = Board.getPiece(pos);
            if(p == null)
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
            //up
            Position pos = new Position(Position.X - 1, Position.Y);
            while (Board.validPosition(pos) && canMove(pos))
            {
                mat[pos.X, pos.Y] = true;
                if (this.Board.getPiece(pos) != null && this.Board.getPiece(pos).Color != this.Color)
                {
                    break;
                }
                pos.X -= 1;
            }
            //down
            pos.X = Position.X + 1;
            pos.Y = Position.Y;
            while (Board.validPosition(pos) && canMove(pos))
            {
                mat[pos.X, pos.Y] = true;
                if (this.Board.getPiece(pos) != null && this.Board.getPiece(pos).Color != this.Color)
                {
                    break;
                }
                pos.X += 1;
            }

            //left
            pos.X = Position.X;
            pos.Y = Position.Y - 1;
            while (Board.validPosition(pos) && canMove(pos))
            {
                mat[pos.X, pos.Y] = true;
                if (this.Board.getPiece(pos) != null && this.Board.getPiece(pos).Color != this.Color)
                {
                    break;
                }
                pos.Y -= 1;
            }
            //right
            pos.X = Position.X;
            pos.Y = Position.Y + 1;
            while (Board.validPosition(pos) && canMove(pos))
            {
                mat[pos.X, pos.Y] = true;
                if (this.Board.getPiece(pos) != null && this.Board.getPiece(pos).Color != this.Color)
                {
                    break;
                }
                pos.Y += 1;
            }


            return mat;

        }

        public override string ToString()
        {
            return "ROOK";
        }
    }
}
