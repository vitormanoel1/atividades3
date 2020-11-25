using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("qual o tipo de combustivel? a - Álcool ou g - Gasolina: ");
            string tipo = Console.ReadLine();

            Console.Write("digite a quantidade de litros que deseja abastecer: ");
            float litros = float.Parse(Console.ReadLine());

            //declaraçao de variavel
            float precoAlcool = 4.9f;
            float precoGasolina= 5.3f;
            float  ResultadoDaFuncao;

            switch (tipo.ToLower())
            {
                case "a":
                    ResultadoDaFuncao = ValorASerPago(litros,precoAlcool,0.03f,0.05f);
                    Console.WriteLine($"o valor a ser pago é de: {ResultadoDaFuncao}");
                    break;
                case "b":
                    ResultadoDaFuncao = ValorASerPago(litros,precoGasolina,0.04f,0.06f);
                    Console.WriteLine($"o valor a ser pago é de: {ResultadoDaFuncao}");
                    break;
                default:
                    Console.WriteLine("Valor inválido");
                    break;
            } // fim do switch

            static float ValorASerPago(float litros, float preco, float perc1, float perc2){
            float percentualDesconto;
            if(litros <= 20){
                percentualDesconto = perc1;
            }else
            {
                percentualDesconto = perc2;
            }
            float totalDoDesconto = (litros * preco) * percentualDesconto;
            float valorBruto = (litros * preco);
            float valorAPagar = valorBruto = totalDoDesconto;
            return valorAPagar;
            }
        }
    }
}
