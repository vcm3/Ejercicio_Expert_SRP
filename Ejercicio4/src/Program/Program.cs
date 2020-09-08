using System;
using Logica;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] gameBoard; //variable que representa el tablero
            int boardWidth; //variabe que representa el ancho del tablero
            int boardHeight; //variabe que representa altura del tablero
            while (true)
            {
                Console.Clear();
                Text.StringBuilder s = new Text.StringBuilder();
                for (int y = 0; y<height;y++)
                {
                    for (int x = 0; x<width; x++)
                    {
                        if(b[x,y])
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
                //=================================================
                //Invocar método para calcular siguiente generación
                //=================================================
                Threading.Sleep(300);
            }
        }
    }
}
