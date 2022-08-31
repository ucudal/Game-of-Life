using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            Tablero gameBoard = new Tablero(ReadFile.OpenFile(@"../../assets/board.txt"));
            int boardHeight = gameBoard.getHeight();
            int boardWidth = gameBoard.getWidth();
            ImprimirTablero.Imprimir(gameBoard, boardHeight, boardWidth);
        }
    }
}
