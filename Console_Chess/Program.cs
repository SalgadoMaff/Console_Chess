using Console_Chess;
using System.Net.NetworkInformation;


try
{
    Board board = new Board();
    PosDict posdict = new PosDict();
    board.putPiece(new King(Color.WHITE, board), new Position(0, 0));
    board.putPiece(new Queen(Color.BLACK, board), new Position(1, 0));
    View.printBoard(board,posdict);
    Console.WriteLine();
    Console.WriteLine(posdict.toPosition('A',1).ToString());
}
catch (BoardException e)
{

    Console.WriteLine(e.Message);
}

