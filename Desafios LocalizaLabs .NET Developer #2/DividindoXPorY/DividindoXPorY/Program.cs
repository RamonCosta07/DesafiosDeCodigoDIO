using System;
using System.Globalization;

/* Você terá o desafio de escrever um algoritmo que leia 2 números
 * e imprima o resultado da divisão do primeiro pelo segundo.
 * Caso não for possível, mostre a mensagem “divisao impossivel”
 * para os valores em questão.
 */

namespace DividindoXPorY
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < limit; i++)
            {
                string[] line = Console.ReadLine().Split(" ");
                double x = double.Parse(line[0]);
                double y = double.Parse(line[1]);
                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    Console.WriteLine((x / y).ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}