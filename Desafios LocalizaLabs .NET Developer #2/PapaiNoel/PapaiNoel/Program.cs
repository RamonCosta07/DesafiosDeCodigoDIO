using System;

namespace PapaiNoel
{
    /* Papai Noel está brincando com seus duendes para entretê-los durante
     * a véspera do Natal. A brincadeira consiste nos elfos escreverem
     * números em pedaços de papel e colocarem no gorro do Papai Noel.
     * Após todos terminarem de colocar os números Noel sorteia um papel
     * e aquele número representa quantos "Ho" o Noel deve falar.

     * Seu trabalho é ajudar o Papai Noel montando um problema que
     * mostre todos os "Ho" que ele deve falar dado o número sorteado.
     * A saída é composta por todos "Ho" que Papai Noel deve falar
     * separados por um espaço. Após o último "Ho" deve ser apresentado
     * um "!" encerrando o programa.
     */
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while(n > 0)
            {
                if (n > 1)
                {
                    Console.Write("Ho ");
                } else
                {
                    Console.Write("Ho!");
                }
                n--;
            }
        }
    }
}