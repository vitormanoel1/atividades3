﻿using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
                15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
                declarado.
            */

            int[] numeros = new int[15];

            for(int i = 0; i < numeros.Length; i++) 
            {
                Console.Write("Digite o numero: ");
                numeros[i] = int.Parse(Console.ReadLine());  
            }
 
            Array.Reverse(numeros);
            
            for(int i = 0; i < numeros.Length; i++) 
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
