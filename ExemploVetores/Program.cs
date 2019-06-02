using System;

namespace ExemploVetores {
    class Program {
        static void Main(string[] args) {

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());
            Quarto[] vect = new Quarto[10];

            for (int i = 0; i < n; i++) {
                Console.WriteLine();
                Console.WriteLine("Rent #{0}:", i + 1);
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                if (room < 10 && vect[room] == null) {
                    vect[room] = new Quarto { Name = name, Email = email };
                }
            }

            Console.WriteLine();
            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < 10; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
