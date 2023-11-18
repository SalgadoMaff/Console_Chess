using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Chess
{
    internal class King : Piece
    {
        public King(Color color, Board board) : base(color, board)
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
            //up
            Position pos = new Position(this.Position.X - 1, this.Position.Y);
            if (Board.validPosition(pos) && canMove(pos))
            {
                mat[pos.X, pos.Y] = true;
            }
            //up right
            pos.X = this.Position.X - 1;
            pos.Y = this.Position.Y + 1;
            if (Board.validPosition(pos) && canMove(pos))
            {
                mat[pos.X, pos.Y] = true;
            }
            //right
            pos.X = this.Position.X;
            pos.Y=this.Position.Y + 1;
            if (Board.validPosition(pos) && canMove(pos))
            {
                mat[pos.X, pos.Y] = true;
            }
            //down right
            pos.X = this.Position.X + 1;
            pos.Y= this.Position.Y + 1;
            if (Board.validPosition(pos) && canMove(pos))
            {
                mat[pos.X, pos.Y] = true;
            }
            //down
            pos.X = this.Position.X + 1;
            pos.Y=this.Position.Y;
            if (Board.validPosition(pos) && canMove(pos))
            {
                mat[pos.X, pos.Y] = true;
            }
            //down left
            pos.X = this.Position.X + 1;
            pos.Y=this.Position.Y - 1;
            if (Board.validPosition(pos) && canMove(pos))
            {
                mat[pos.X, pos.Y] = true;
            }
            //left
            pos.X = this.Position.X;
            pos.Y = this.Position.Y - 1;
            if (Board.validPosition(pos) && canMove(pos))
            {
                mat[pos.X, pos.Y] = true;
            }
            //up left
            pos.X = this.Position.X - 1;
            pos.Y = this.Position.Y - 1;
            if (Board.validPosition(pos) && canMove(pos))
            {
                mat[pos.X, pos.Y] = true;
            }
            return mat;
        }

        public override string ToString()
        {
            return "KING";
        }
    }
}
