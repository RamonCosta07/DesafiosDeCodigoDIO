using System;
using System.Globalization;

/* Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido
 * o valor de seu raio (R). A fórmula para calcular o volume é: (4/3) * pi * R3.
 * Considere (atribua) para pi o valor 3.14159
 */

namespace Esfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double volume = Math.Pow(raio, 3) * (4 / 3.0) * pi;
            Console.WriteLine($"VOLUME = " +
                $"{(volume).ToString("F3", CultureInfo.InvariantCulture)}");

        }
    }
}