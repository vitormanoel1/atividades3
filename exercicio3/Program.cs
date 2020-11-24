using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
                preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
                desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
                . Se quantidade <= 5 o desconto será de 2%
                . Se quantidade > 5 e quantidade <=10 o desconto será de 3%
                .Se quantidade > 10 o desconto será de 5%
                Dica: utilize if / else if / else
            */

            Console.Write("digite descrição do produto: ");
            string descricao = Console.ReadLine();

            Console.Write("digite a quantidade usada: ");
            float quantidade = float.Parse(Console.ReadLine());

            Console.Write("digite o preço unitário: ");
            float precounitario = float.Parse(Console.ReadLine());

            if(quantidade <= 5) {
                var desconto = 0.02;
                var total = quantidade * precounitario;
                var totalpagar = total - desconto;
                Console.WriteLine("Total a pagar: " + totalpagar);
            } 
            else if(quantidade > 5 && quantidade <= 10) {
                var desconto = 0.03;
                var total = quantidade * precounitario;
                var totalpagar = total - desconto;
                Console.WriteLine("Total a pagar: " + totalpagar);
            } 
            else {
                var desconto = 0.05;
                var total = quantidade * precounitario;
                var totalpagar = total - desconto;
                Console.WriteLine("Total a pagar: " + totalpagar);
            }
        }
    }
}
