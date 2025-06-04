namespace TicTacToe.ConsoleApp;

public class GameBoard
{
    private char[,] _grid;

    public int Rows { get; } = 3;
    public int Columns { get; } = 3;

    public GameBoard()
    {
        _grid = new char[Columns, Rows];

        int count = 1;
        for (int row = 0; row < Rows; row++)
        {
            for (int Column = 0; Column < Columns; Column++)
            {
                _grid[Column, row] = (char)(count++ + '0');
            }
        }
    }

    public void DrawBoard()
    {
        Console.WriteLine("-------------");

        for (int row = 0; row < _grid.GetLength(0); row++)
        {
            Console.Write("|");

            for (int column = 0; column < _grid.GetLength(0); column++)
            {
                Console.Write(" " + _grid[column, row] + " |");
            }
            Console.WriteLine("");
            Console.WriteLine("-------------");
        }

    }
}