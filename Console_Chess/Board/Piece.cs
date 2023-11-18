using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Chess
{
    internal class Piece
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
    }
}
