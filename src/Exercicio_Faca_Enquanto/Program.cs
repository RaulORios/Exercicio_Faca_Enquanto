using System;
using System.Globalization;

namespace Exercicio_Faca_Enquanto
{
    class Program
    {
        static void Main(string[] args)
        {
            double C, F;
            char repetir;

            do
            {
                Console.Write("Digite a temperatura em Celsius: ");
                C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                F = (9.0 * C) / 5.0 + 32.0;

                Console.WriteLine($"Equivalente em Fahrenheit: {F.ToString("F1", CultureInfo.InvariantCulture)}");

                Console.Write("Deseja repetir (S/N)? ");
                repetir = char.Parse(Console.ReadLine().ToUpper());
            } while (repetir == 'S');

            Console.ReadKey();
                       
        }
    }
}
