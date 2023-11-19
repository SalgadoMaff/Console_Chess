using Console_Chess;
using System.Net.NetworkInformation;


try
{

    PosDict posdict = new PosDict();
    Board board = populateBoard(posdict);
    Match Chess_match = new Match(Color.WHITE, board);
    while (!Chess_match.finished)
    {
        try
        {
            Console.Clear();
            View.printBoard(board, posdict);
            Console.WriteLine();
            Console.WriteLine("Turn: " + Chess_match.getTurn());
            Console.WriteLine(Chess_match.getPlayer() + "'s turn");
            Console.WriteLine();
            Console.WriteLine("Origin:");
            Position origin = View.readChessPosition(posdict);
            Chess_match.validatePositionOrigin(origin);
            Console.Clear();

            bool[,] possiblePositions = Chess_match.board.getPiece(origin).possibleMovements();
            View.printBoard(board, posdict, possiblePositions);
            Console.WriteLine();
            
            Console.WriteLine("Target:");
            Position target = View.readChessPosition(posdict);
            Chess_match.validatePositionTarget(origin, target);
            Chess_match.doMove(origin, target);
        }
        catch (BoardException e)
        {

            Console.WriteLine(e.Message);
            Console.ReadLine();
        }


    }

}
catch (BoardException e)
{

    Console.WriteLine(e.Message);
    Console.ReadLine();
}

Board populateBoard(PosDict posdict)
{
    Board board = new Board();

    board.putPiece(new Pawn(Color.BLACK, board), posdict.toPosition('A', 2));
    board.putPiece(new Pawn(Color.BLACK, board), posdict.toPosition('B', 2));
    board.putPiece(new Pawn(Color.BLACK, board), posdict.toPosition('C', 2));
    board.putPiece(new Pawn(Color.BLACK, board), posdict.toPosition('D', 2));
    board.putPiece(new Pawn(Color.BLACK, board), posdict.toPosition('E', 2));
    board.putPiece(new Pawn(Color.BLACK, board), posdict.toPosition('F', 2));
    board.putPiece(new Pawn(Color.BLACK, board), posdict.toPosition('G', 2));
    board.putPiece(new Pawn(Color.BLACK, board), posdict.toPosition('H', 2));

    board.putPiece(new Rook(Color.BLACK, board), posdict.toPosition('A', 1));
    board.putPiece(new Knight(Color.BLACK, board), posdict.toPosition('B', 1));
    board.putPiece(new Bishop(Color.BLACK, board), posdict.toPosition('C', 1));
    board.putPiece(new Queen(Color.BLACK, board), posdict.toPosition('D', 1));
    board.putPiece(new King(Color.BLACK, board), posdict.toPosition('E', 1));
    board.putPiece(new Bishop(Color.BLACK, board), posdict.toPosition('F', 1));
    board.putPiece(new Knight(Color.BLACK, board), posdict.toPosition('G', 1));
    board.putPiece(new Rook(Color.BLACK, board), posdict.toPosition('H', 1));

    board.putPiece(new Pawn(Color.WHITE, board), posdict.toPosition('A', 7));
    board.putPiece(new Pawn(Color.WHITE, board), posdict.toPosition('B', 7));
    board.putPiece(new Pawn(Color.WHITE, board), posdict.toPosition('C', 7));
    board.putPiece(new Pawn(Color.WHITE, board), posdict.toPosition('D', 7));
    board.putPiece(new Pawn(Color.WHITE, board), posdict.toPosition('E', 7));
    board.putPiece(new Pawn(Color.WHITE, board), posdict.toPosition('F', 7));
    board.putPiece(new Pawn(Color.WHITE, board), posdict.toPosition('G', 7));
    board.putPiece(new Pawn(Color.WHITE, board), posdict.toPosition('H', 7));

    board.putPiece(new Rook(Color.WHITE, board), posdict.toPosition('A', 8));
    board.putPiece(new Knight(Color.WHITE, board), posdict.toPosition('B', 8));
    board.putPiece(new Bishop(Color.WHITE, board), posdict.toPosition('C', 8));
    board.putPiece(new Queen(Color.WHITE, board), posdict.toPosition('D', 8));
    board.putPiece(new King(Color.WHITE, board), posdict.toPosition('E', 8));
    board.putPiece(new Bishop(Color.WHITE, board), posdict.toPosition('F', 8));
    board.putPiece(new Knight(Color.WHITE, board), posdict.toPosition('G', 8));
    board.putPiece(new Rook(Color.WHITE, board), posdict.toPosition('H', 8));

    return board;
}

