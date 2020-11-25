using System;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
                lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
                pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
                entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.
            */

            string[] lista = new string[10];
            for(int i = 1; i < lista.Length; i++) {
                Console.Write("Digite o nome: ");
                lista[i] = Console.ReadLine();
            }
            Console.WriteLine();

            Console.Write("Digite nome para ser verificado na lista: ");
            string nome = Console.ReadLine();

            Console.WriteLine();
            
            for(int i = 1; i < lista.Length; i++) {
                if(nome == lista[i]) {
                    Console.WriteLine($"achei {i}");
                } else {
                    Console.WriteLine($"nao achei {i}");
                }
            }
        }
    }
}
