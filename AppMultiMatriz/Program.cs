using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMultiMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Matrices multidimensionales rectangulares
            int[,] x = new int[3, 3];
            int[,] y = new int[3, 2];
            int[,] z = new int[3, 2];
            leer(x);
            imprimir(x);
            leer(y);
            imprimir(y);

            Multiplicar(x, y, z);
            imprimir(z);
            int[][,] matriz = new int[3][,];
            inicializar(matriz);
            Console.ReadKey();

        }
        public static void inicializar(int [3][,] matriz)
        {
            matriz[0]  = new int[3, 3];//primera
            matriz[1]  = new int[3, 2];//segunda

            matriz[2]  = new int[3, 2];//tercera
            Console.WriteLine("Multiplicacion de matrices utilizando dimensiones escalonadas y rectangulares");
            leer(matriz[0]);
            leer(matriz[1]);
            Multiplicar(matriz[0], matriz[1], matriz[2]);
            imprimir(matriz[2]);

        }
        public static void Multiplicar(int [,] A, int [,] B, int[,] C)
        {
            for(int i = 0; i <= A.GetLength(0); i++)
            {
                for(int j = 0; j <= B.GetLength(1); j++)
                {
                    for(int k = 0; k <= C.GetLength(0); k++)
                    {
                        C[i, j] = C[i, j] + A[i, k] * B[k, j];
                    }
                }
            }
        }
        public static void leer(int[,] matriz)
        {
            Console.WriteLine("Ingrese los elementos de la matriz:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    string aux;
                    Console.Write(" [ {0}, {1} ] ", i, j);
                    aux = Console.ReadLine();
                    matriz[i, j] = Int32.Parse(aux);
                }

                Console.WriteLine();
            }
        }
        public static void imprimir(int [,] matriz)
        {
            Console.Write("\n Impresion de la matriz");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {

                    Console.Write(" {0} ", matriz[i, j]);
                    
                }

                Console.WriteLine();
            }
        }
    }
}
