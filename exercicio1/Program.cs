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

            Console.WriteLine("Ano de nascimento: ");
            int anoNasc = int.Parse(Console.ReadLine());

            int anoAtual = 2020;
            int idade = anoAtual - anoNasc;

            if(idade >= 18 ){
                Console.WriteLine("voce pode votar");
            } else if(idade < 18) {
                Console.WriteLine("voce nao pode votar");
            }

        }
    }
}
