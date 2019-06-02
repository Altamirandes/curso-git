using System;

namespace ExemploMatriz2 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Número de Linhas: ");
            int l = int.Parse(Console.ReadLine());
            Console.Write("Número de Colunas: ");
            int c = int.Parse(Console.ReadLine());

            int[,] mat = new int[l,c];
            Console.WriteLine();

            for (int i = 0; i < l; i++) {
                Console.Write("Informe a Linha[" + i + "] = ");
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < c; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.Write("Informe o Número: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("\nLocalização: ");
            for (int i = 0; i < l; i++) {
                for (int j = 0; j < c; j++) {
                    if (mat[i, j] == num) {
                        Console.WriteLine("\nPosição: [" + i + "," + j + "]");
                        if ((j - 1) >= 0) {
                            Console.WriteLine("Esquerda: " + mat[i, j - 1]);
                        }
                        if ((j + 1) < c) {
                            Console.WriteLine("Direita: " + mat[i, j + 1]);
                        }
                        if ((i - 1) >= 0) {
                            Console.WriteLine("Acima: " + mat[i - 1, j]);
                        }
                        if ((i + 1) < l) {
                            Console.WriteLine("Abaixo: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
