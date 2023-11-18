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
            throw new NotImplementedException();
        }

        public override bool[,] possibleMovements()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "KNIGHT";
        }
    }
}
