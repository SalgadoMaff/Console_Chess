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
        public override string ToString()
        {
            return "KING";
        }
    }
}
