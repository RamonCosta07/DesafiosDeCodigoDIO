using System;

/* Dado um número X, retorne o menor número par maior do que X.

        Entrada:
Uma linha contendo um número  0 < X < 107.

        Saída:
Uma linha contendo a resposta do problema.
*/

namespace SucessorPar
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            if(x % 2 == 0)
            {
                Console.WriteLine(x+2);
            } else
            {
                Console.WriteLine(x+1);
            }
        }
    }
}
