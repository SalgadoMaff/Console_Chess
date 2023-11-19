using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Chess
{
    abstract class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int QttMovement { get; protected set; }
        public Board Board { get; set; }

        public Piece(Color color, Board board)
        {

            Color = color;
            Board = board;
            QttMovement = 0;
        }

        public void incMovement()
        {
            QttMovement++;
        }
        public void decreaseMovement()
        {
            QttMovement--;
        }

        public bool isTherePossibleMovements()
        {
            bool[,] mat = possibleMovements();
            for (int i = 0; i < Board.X; i++)
            {
                for (int j = 0; j < Board.Y; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool canMoveTo(Position pos)
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

        public bool canMove(Position target)
        {
            return possibleMovements()[target.X, target.Y];

        }

        public abstract bool[,] possibleMovements();
        


    }
}
