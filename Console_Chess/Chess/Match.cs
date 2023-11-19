using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Console_Chess
{
    internal class Match
    {
        public Board board { get; private set; }
        private int _turn;
        private Color _currentPlayer;
        public bool finished { get; private set; }
        private HashSet<Piece> pieces = new HashSet<Piece>();
        private HashSet<Piece> captured = new HashSet<Piece>();
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
            if (captured != null) { this.captured.Add(captured); }

        }

        internal void doMove(Position origin, Position target)
        {
            movePiece(origin, target);
            _turn++;
            changePlayer();
        }

        public void printMatch(Board board, PosDict posdict)
        {
            Console.Clear();
            View.printBoard(board, posdict);
            Console.WriteLine();
            this.printCaptured();
            Console.WriteLine();
            Console.WriteLine("Turn: " + this.getTurn());
            Console.WriteLine(this.getPlayer() + "'s turn");
            Console.WriteLine();
        }

        private void printCaptured()
        {
            Console.Write("White pieces captured: ");
            foreach (Piece piece in this.capturedPieces(Color.WHITE))
            {
                Console.Write(piece.ToString()+' ');
            }
            Console.WriteLine();
            Console.Write("Black pieces captured: ");
            foreach (Piece piece in this.capturedPieces(Color.BLACK))
            {
                Console.Write(piece.ToString()+' ');
            }
            Console.WriteLine();
        }

        public void validatePositionTarget(Position origin, Position target)
        {
            if (!board.getPiece(origin).canMove(target))
            {
                throw new BoardException("Invalid position!");
            }
        }
        public void validatePositionOrigin(Position origin)
        {
            if (board.getPiece(origin) == null)
            {
                throw new BoardException("There isn't a piece in this position!");
            }
            if (board.getPiece(origin).Color != _currentPlayer)
            {
                throw new BoardException($"It's not {board.getPiece(origin).Color}'s turn!");
            }
            if (!board.getPiece(origin).isTherePossibleMovements())
            {
                throw new BoardException("Piece's movement is blocked!");
            }
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

        internal void populateHash(Board board)
        {
            for (int i = 0; i < board.X; i++)
            {
                for (int j = 0; j < board.Y; j++)
                {
                    Position pos = new Position(i, j);
                    if (board.getPiece(pos) != null)
                    {
                        this.pieces.Add(board.getPiece(pos));
                    }
                }
            }
        }
        public HashSet<Piece> capturedPieces(Color color)
        {
            HashSet<Piece> aux = new HashSet<Piece>();
            foreach (var piece in this.captured)
            {
                if (piece.Color == color)
                {
                    aux.Add(piece);
                }
            }
            return aux;
        }
        public HashSet<Piece> inGamePieces(Color color)
        {
            HashSet<Piece> aux = new HashSet<Piece>();
            foreach (var piece in this.pieces)
            {
                if (piece.Color == color)
                {
                    aux.Add(piece);
                }
            }
            aux.ExceptWith(this.capturedPieces(color));
            return aux;
        }
    }
}
