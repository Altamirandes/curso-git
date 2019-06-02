using System;
using System.Globalization;

namespace ExemploClasseEstatica {
    class Program {
        static void Main(string[] args) {

            Console.Write("Qual é a cotação do dólar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai compra? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = Conversor.ConversorDeMoeda(quantia, cotacao);
            Console.WriteLine("Valor a ser pago em reais = " + resultado.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
