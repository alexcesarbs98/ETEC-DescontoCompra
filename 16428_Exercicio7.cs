using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual total da vanda:");
            double valor = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Qual a forma de pagamento? (DI / CA / CH):");
            string pagamento = Console.ReadLine().ToUpper();

            if (pagamento == "DI") {

                Console.WriteLine("Você ganhou 10% de desconto, no valor de:" + (valor * 0.1).ToString("C"));
                Console.WriteLine("O valor da venda com desconto é: " + (valor - (valor * 0.1)).ToString("C"));

            }
            else if (pagamento == "CA"){

                Console.WriteLine("Você ganhou 7,5% de desconto, no valor de:" + (valor * 0.075).ToString("C"));
                Console.WriteLine("O valor da venda com desconto é: " + (valor - (valor * 0.075)).ToString("C"));

            }
            else if (pagamento == "CH")
            {
                Console.WriteLine("Você ganhou 5% de desconto, no valor de:" + (valor * 0.05).ToString("C"));
                Console.WriteLine("O valor da venda com desconto é: " + (valor - (valor * 0.05)).ToString("C"));
            }
            else
            {
                Console.WriteLine("Forma de pagamento invalida");
            }
        }
    }
}
