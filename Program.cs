using System.Reflection.Metadata.Ecma335;

namespace Batata {
    public class Program {

        public static int Somar(int numero1, int numero2) {
        return numero1 + numero2;  
    }

        private static void Main(string[] args)
        {

            int num1, num2, resultado;

            Console.WriteLine("Digite um número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A soma é: " + (num1 + num2));

            resultado = Programex.Somar(num1, num2);

            Console.WriteLine("A soma é: " + (resultado) + "saiudhsiaudhsaui");
            Console.WriteLine($"A soma é: {resultado} saduishadihsaiduhsauidh");



        }

    }
}
