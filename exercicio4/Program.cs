using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
                menor valor lido.
            */

            Console.Write("digite o valor: ");
            int valor = int.Parse(Console.ReadLine());

            int maior = valor;
            int menor = valor;

            for(int i = 1; i < 10; i++) 
            {
                Console.Write("digite o valor: ");
                valor = int.Parse(Console.ReadLine());

                if(valor > maior)
                {
                    maior = valor;
                } 
                else if(valor < menor)
                {
                    menor = valor;
                }
            }
                Console.Write("valor maior: " + maior);
                Console.Write("valor menor: " + menor);
        }
    }
}
