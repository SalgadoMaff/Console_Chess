using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Chess
{
    internal class Pawn : Piece
    {
        public Pawn(Color color, Board board) : base(color, board)
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
            Position pos = new Position();
            pos.Y = this.Position.Y;
            if (this.Color == Color.BLACK)
            {
                if (this.QttMovement == 0)
                {
                    for (int i = 1; i < 3; i++)
                    {
                        pos.X = this.Position.X - i;
                        if (Board.validPosition(pos) && canMove(pos) && this.Board.getPiece(pos) == null)
                        {
                            mat[pos.X, pos.Y] = true;
                        }
                    }


                }
                else
                {
                    //pawnNormalMove
                    pos.X = this.Position.X - 1;
                    if (Board.validPosition(pos) && canMove(pos) && this.Board.getPiece(pos) == null)
                    {
                        mat[pos.X, pos.Y] = true;
                    }

                    //pawnAttack
                    pos.Y = this.Position.Y + 1;
                    if (Board.validPosition(pos) && this.canPawnAttack(pos))
                    {
                        mat[pos.X, pos.Y] = true;
                    }
                    pos.Y = this.Position.Y - 1;
                    if (Board.validPosition(pos) && this.canPawnAttack(pos))
                    {
                        mat[pos.X, pos.Y] = true;
                    }

                }
            }
            else
            {
                if (this.QttMovement == 0)
                {
                    for (int i = 1; i < 3; i++)
                    {
                        pos.X = Position.X + i;
                        if (Board.validPosition(pos) && canMove(pos))
                        {
                            mat[pos.X, pos.Y] = true;
                        }
                    }

                }
                else
                {
                    //pawnNormalMove
                    pos.X = this.Position.X + 1;
                    if (Board.validPosition(pos) && canMove(pos))
                    {
                        mat[pos.X, pos.Y] = true;
                    }

                    //pawnAttack
                    pos.Y = this.Position.Y + 1;
                    if (Board.validPosition(pos) && this.canPawnAttack(pos))
                    {
                        mat[pos.X, pos.Y] = true;
                    }
                    pos.Y = this.Position.Y - 1;
                    if (Board.validPosition(pos) && this.canPawnAttack(pos))
                    {
                        mat[pos.X, pos.Y] = true;
                    }
                }
            }
            return mat;
        }
        public bool canPawnAttack(Position pos)
        {
            if (Board.getPiece(pos) != null)
            {
                if (Board.getPiece(pos).Color != this.Color)
                {
                    return true;
                }
            }
            return false;

        }
        public override string ToString()
        {
            return "PAWN";
        }


    }
}
