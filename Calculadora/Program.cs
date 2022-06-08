using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        enum Menu { Soma = 1, Subtracao = 2, Divisao = 3, Multiplicacao = 4, Potencia = 5, Raiz = 6, Sair = 7 }
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair) // Enquanto o usuário NÃO (!) ESCOLHER SAIR EXIBA O MENU
            {

                Console.WriteLine("Seja bem vindo ao Calc, Selecione uma das opções:");
                Console.Write("1 - Soma\n2 - Subtração\n3 - Divisão\n4 - Multiplicação\n5 - Potência\n6 - Raiz\n7 - Sair\n");

                /*
                String opcaoTXT = Console.ReadLine();
                int opcaoInt = int.Parse(opcaoTXT);
                Menu opcao = (Menu)opcaoInt;
                */

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }
                //Console.WriteLine(opcao);
                //Console.ReadLine();
                Console.Clear();
            }

        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois numeros:");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para  o menu");
            Console.ReadLine();
        }

        static void Subtracao()
        {
            Console.WriteLine("Subtração de dois numeros:");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para  o menu");
            Console.ReadLine();
        }

        static void Divisao()
        {
            Console.WriteLine("Divisão de dois numeros:");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a/(float)b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para  o menu");
            Console.ReadLine();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicação de dois numeros:");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para  o menu");
            Console.ReadLine();
        }


    }

}
