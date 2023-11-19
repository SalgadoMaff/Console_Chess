﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Chess
{
    internal class Bishop : Piece
    {
        public Bishop(Color color, Board board) : base(color, board)
        {
        }

        

        public override bool[,] possibleMovements()
        {
            bool[,] mat = new bool[this.Board.X, this.Board.Y];
            //up right
            Position pos = new Position(this.Position.X - 1, this.Position.Y + 1);
            while (Board.validPosition(pos) && canMoveTo(pos))
            {
                mat[pos.X, pos.Y] = true;
                if (this.Board.getPiece(pos) != null && this.Board.getPiece(pos).Color != this.Color)
                {
                    break;
                }
                pos.X -= 1;
                pos.Y += 1;
            }
            //down right
            pos.X = this.Position.X + 1;
            pos.Y = this.Position.Y + 1;
            while (Board.validPosition(pos) && canMoveTo(pos))
            {
                mat[pos.X, pos.Y] = true;
                if (this.Board.getPiece(pos) != null && this.Board.getPiece(pos).Color != this.Color)
                {
                    break;
                }
                pos.X += 1;
                pos.Y += 1;
            }
            //down left
            pos.X = this.Position.X + 1;
            pos.Y = this.Position.Y - 1;
            while (Board.validPosition(pos) && canMoveTo(pos))
            {
                mat[pos.X, pos.Y] = true;
                if (this.Board.getPiece(pos) != null && this.Board.getPiece(pos).Color != this.Color)
                {
                    break;
                }
                pos.X += 1;
                pos.Y -= 1;
            }
            //up left
            pos.X = this.Position.X - 1;
            pos.Y = this.Position.Y - 1;
            while (Board.validPosition(pos) && canMoveTo(pos))
            {
                mat[pos.X, pos.Y] = true;
                if (this.Board.getPiece(pos) != null && this.Board.getPiece(pos).Color != this.Color)
                {
                    break;
                }
                pos.X -= 1;
                pos.Y -= 1;
            }
            return mat;
        }

        public override string ToString()
        {
            return "BISHOP";
        }
    }
}
