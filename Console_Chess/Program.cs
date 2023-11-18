using Console_Chess;
using System.Net.NetworkInformation;


try
{
    Board board = new Board();
    PosDict posdict = new PosDict();
    Match Chess_match = new Match(Color.WHITE,board);
    board.putPiece(new Rook(Color.BLACK, board), posdict.toPosition('D', 1));
    board.putPiece(new Rook(Color.BLACK, board), posdict.toPosition('E', 1));
    board.putPiece(new Rook(Color.BLACK, board), posdict.toPosition('D', 2));
    board.putPiece(new Rook(Color.BLACK, board), posdict.toPosition('E', 2));
    board.putPiece(new Rook(Color.WHITE, board), posdict.toPosition('E', 8));
    board.putPiece(new Rook(Color.WHITE, board), posdict.toPosition('E', 7));
    board.putPiece(new Rook(Color.WHITE, board), posdict.toPosition('D', 8));
    board.putPiece(new Rook(Color.WHITE, board), posdict.toPosition('D', 7));
    while (!Chess_match.finished)
    {
        Console.Clear();
        View.printBoard(board, posdict);
        Console.WriteLine("Origin:");
        Position origin = View.readChessPosition(posdict);
        Console.WriteLine("Target:");
        Position target = View.readChessPosition(posdict);
        Chess_match.movePiece(origin, target);

    }

    //board.putPiece(new King(Color.WHITE, board), new Position(0, 0));
    //board.putPiece(new Queen(Color.BLACK, board), new Position(1, 0));
    //Console.WriteLine();
    //Console.WriteLine(posdict.toPosition('A',1).ToString());
}
catch (BoardException e)
{

    Console.WriteLine(e.Message);
}

