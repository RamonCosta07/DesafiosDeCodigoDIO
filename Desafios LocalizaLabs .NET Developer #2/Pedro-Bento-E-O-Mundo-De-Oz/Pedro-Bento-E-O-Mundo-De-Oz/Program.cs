using System;
using System.Collections.Generic;
using System.Linq;

namespace Pedro_Bento_E_O_Mundo_De_Oz
{
    /* No jogo, O Mundo de Oz, Pedro Bento é o líder do Tribunal, por causa disso
    ele é uma das pessoas mais importantes do mundo, no jogo. Além disso, Pedro
    Bento possui um grande tesouro, o qual possui diversos tipos de jóias.
    Pedro Bento está muito curioso para saber quantos tipos de jóias diferentes seu
    tesouro possui.
    Sabendo que você é o melhor programador do mundo, Pedro Bento te contratou para
    verificar quantos tipos de jóias distintas ele tem em seu tesouro.
    - Entrada
    A entrada consiste de várias linhas e cada uma contém uma string que descreve
    uma das jóias de Pedro Bento. Essa string é composta apenas dos caracteres
    '(' e ')', a soma do tamanho de todas as strings não excede 106.
    - Saída
    Imprima quantos tipos de jóias distintas Pedro Bento possui. 
    */
    class Program
    {
        static void Main(string[] args)
        {
            List<string> joias = new List<string>();
            List<string> joiasQnt = new List<string>();
            string e = "-";
            while (!string.IsNullOrWhiteSpace(e))
            {
                e = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(e))
                {
                    joias.Add(e);
                }
            }

            IEnumerable<string> distinctJoias = joias.Distinct();
            Console.WriteLine(distinctJoias.Count());
        }
    }
}