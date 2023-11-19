﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Chess
{
    internal class Match
    {
        public Board board { get; private set; }
        private int _turn;
        private Color _currentPlayer;
        public bool finished { get; private set; }

        public Match(Color currentPlayer, Board board)
        {
            this.board = board;
            _turn = 1;
            _currentPlayer = currentPlayer;
            finished = false;
        }

        public void movePiece(Position origin, Position target)
        {
            Piece p = board.removePiece(origin);
            p.incMovement();
            Piece captured = board.removePiece(target);
            board.putPiece(p, target);

        }

        internal void doMove(Position origin, Position target)
        {
            movePiece(origin, target);
            _turn++;
            changePlayer();
        }
        private void changePlayer()
        {
            if (_currentPlayer == Color.WHITE)
            {
                _currentPlayer = Color.BLACK;
            }
            else
            {
                _currentPlayer = Color.WHITE;
            }
        }
        public int getTurn() { return this._turn; }
        public string getPlayer()
        {
            if (_currentPlayer == Color.BLACK)
            {
                return "Black";
            }
            return "White";
        }

    }
}
