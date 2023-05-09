using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = { {1, 2, 3}, 
                               {4, 5, 6}, 
                               {7, 8, 9} };

            Console.WriteLine(MultiplicarMatrices(matriz, matriz));

            Console.Read();
        }

        public static int[,] MultiplicarMatrices(int[,] matriz1, int[,] matriz2)
        {
            int[,] resultado = new int[3, 3];

            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    resultado[fila, columna] = 0;

                    for (int k = 0; k < 3; k++)
                    {
                        resultado[fila, columna] += matriz1[fila, k] * matriz2[k, columna];
                    }
                }
            }

            return resultado;
        }


    }
}
