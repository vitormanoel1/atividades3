using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Escreva  um programa  para  ler  o  ano  de  nascimento  de  uma  pessoa  e
            //    escrever uma mensagem que diga se ela poderá ou não votar este ano 
            //    (não é necessário considerar o mês em que ela nasceu).

            Console.WriteLine("digite o ano em que voce nasceu: ");
            int anoNasc = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o ano atual: ");
            int anoAtual = int.Parse(Console.ReadLine());
            if (idade >= 18)
            {
                Console.WriteLine("voce pode votar: ");
            }
            else
            {
                Console.WriteLine("voce nao pode votar ainda: ");
            }

            int soma = anoAtual - anoNasc;
            Console.WriteLine("sua idade e: "+ (soma));
        }
    }
}
