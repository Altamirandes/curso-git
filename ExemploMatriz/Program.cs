using System;

namespace ExemploMatriz {
    class Program {
        static void Main(string[] args) {
            Console.Write("Matriz(n): ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];
            Console.WriteLine();

            int neg = 0;
            for (int i = 0; i < n; i++) {
                Console.Write("Linha[" + i + "] = ");
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                    if (mat[i, j] < 0) {
                        neg++;
                    }
                }
            }

            /*
            Console.WriteLine("\nMatriz:");
            int neg = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write(mat[i,j] + " ");
                    if (mat[i, j] < 0) {
                        neg++;
                    }
                }
                Console.WriteLine();
            }
            */

            Console.Write("\nDiagonal Principal: ");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i,i] + " ");
            }
            Console.WriteLine("\nNegativos: " + neg);
        }
    }
}
