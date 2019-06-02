namespace ExemploClasseEstatica {
    class Conversor {

        public static double Iof = 6.00;

        public static double ConversorDeMoeda(double quantidade, double valor) {
            double total = quantidade * valor;
            return total + (total * Iof / 100);
        }

    }
}
