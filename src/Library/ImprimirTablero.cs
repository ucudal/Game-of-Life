using System;
using System.Text;
using System.Threading;

namespace PII_Game_Of_Life
{
    public class ImprimirTablero
    {
        public static void Imprimir(Tablero tablero, int width, int height)
        {
            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y<height;y++)
                {
                    for (int x = 0; x<width; x++)
                    {
                        if(tablero.Board[x,y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
                }
                Console.WriteLine(s.ToString());
                LogicaDeJuego.Logica(tablero, width, height);
                Thread.Sleep(300);
            }
        }
    }
}