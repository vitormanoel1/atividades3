using System;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
                Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.
            */

            Console.WriteLine("qual tabuada voce deseja ver? ");
            int resposta = int.Parse(Console.ReadLine());

            int resultado;

            for (int contador = 1; contador <= 10; contador++)
            {
                resultado = resposta * contador;
                Console.WriteLine($" {resposta} * {contador} = {resultado} ");
            }
        }
    }
}
