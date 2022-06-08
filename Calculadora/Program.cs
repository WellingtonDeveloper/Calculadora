using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        enum Menu { Soma = 1, Subtracao = 2, Divisão = 3, Multiplicacao = 4, Potencia = 5, Raiz = 6, Sair = 7 }
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo ao Calc, Selecione uma das opções:");
            Console.Write("1 - Soma\n2 - Subtração\n3 - Divisão\n4 - Multiplicação\n5 - Potência\n6 - Raiz\n7 - Sair\n");

            /*
            String opcaoTXT = Console.ReadLine();
            int opcaoInt = int.Parse(opcaoTXT);
            Menu opcao = (Menu)opcaoInt;
            */

            Menu opcao = (Menu)int.Parse(Console.ReadLine());

                Console.WriteLine(opcao);

                Console.ReadLine();
        }
    }
}
