using System;
using System.Globalization;
/*
Escreva um algoritmo para calcular e escrever o valor de S, sendo S dado pela fórmula:
S = 1 + 1/2 + 1/3 + … + 1/100

Entrada:
Não há nenhuma entrada neste problema.

Saída:
A saída contém um valor correspondente ao valor de S.
O valor deve ser impresso com dois dígitos após o ponto decimal.
*/

namespace SequenciaS
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 1;
            for (double i = 2; i <= 100; i++)
            {
                s += (1 / i); 
            }
            var x = Math.Round(s, 2);
            Console.WriteLine(x);
            //Console.WriteLine(s.ToString("N2", new CultureInfo("pt-BR")));
        }
    }
}