namespace PII_Game_Of_Life
{
    public class Tablero
    {
        public bool[,] Board { get; set; }
        public Tablero (bool[,] board)
        {
            this.Board = board;
        }
        public int getWidth()
        {
            return this.Board.GetLength(0);
        }
        public int getHeight()
        {
            return this.Board.GetLength(0);
        }
    }
}