using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        public static void Exercicio1()
        {
            Console.Write("insira o tamanho do vetor: ");
            int tam = int.Parse(Console.ReadLine());

            float[] vetor = new float[tam];

            for (int i = 0; i < tam; i++)
            {
                Console.Write("insira o número {i + 1}: ");
                vetor[i] = float.Parse(Console.ReadLine());
            }

            float menor = vetor[0];
            float maior = vetor[0];
            float soma = vetor[0];

            for (int i = 1; i < tam; i++)
            {
                if (vetor[i] < menor)
                    menor = vetor[i];

                if (vetor[i] > maior)
                    maior = vetor[i];

                soma += vetor[i];
            }

            float media = soma / tam;

            Console.WriteLine("Menor número: " + menor);
            Console.WriteLine("Maior número:" + maior);
            Console.WriteLine("Média aritmética:" + media);
        }
        public static void Exercicio2()
        {
            Console.Write("insira o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());

            float[] vetor = new float[tamanho];
            float soma = 0;

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine("Digite o número");
                vetor[i] = float.Parse(Console.ReadLine());
                soma += vetor[i];
            }

            float media = soma / tamanho;

            Console.WriteLine("valores maiores ou iguais a média:");

            for (int i = 0; i < tamanho; i++)
            {
                if (vetor[i] >= media)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
        }

        static int LerInteiroPositivo()
        {
            int valor;

            while (!int.TryParse(Console.ReadLine(), out valor) || valor <= 0)
            {
                Console.Write("Digite um valor válido (maior que zero): ");
            }

            return valor;
        }
        public static void Exercicio3()
        {
        //    Console.Write("Digite o tamanho do vetor (N): ");
        //    int tamanho = int.Parse(Console.ReadLine());

        //    float[] vetor = new float[tamanho];
        //    float soma = 0;

        //    Random random = new Random();

        //    for (int i = 0; i < tamanho; i++)
        //    {
        //        vetor[i] = random.Next(1, 101); // Gera um número aleatório entre 1 e 100
        //        soma += vetor[i];
        //    }

        //    float media = soma / tamanho;

        //    Console.WriteLine("Números maiores ou iguais à média:");

        //    for (int i = 0; i < tamanho; i++)
        //    {
        //        if (vetor[i] >= media)
        //        {
        //            Console.WriteLine(vetor[i]);
        //        }
        //    }
        //}

        //static int
        //{
        //    int valor;

        //    while (!int.TryParse(Console.ReadLine(), out valor) || valor <= 0)
        //    {
        //        Console.Write("Digite um valor válido (maior que zero): ");
        //    }

        //    return valor;
        //}
        //public static void Exercicio4()
        //{

        //}
        //public static void Exercicio5()
        //{
        //    Console.WriteLine("here ex5 will be encoded");
        //}

        //static void Main(string[] args)
        {

            int option;

            do
            {
                Console.WriteLine("===========MENU=========");
                Console.WriteLine("para executar o exercício 1 - digite 1");
                Console.WriteLine("para executar o exercício 2 - digite 2");
                Console.WriteLine("para executar o exercício 3 - digite 3");
                Console.WriteLine("para executar o exercício 4 - digite 4");
                Console.WriteLine("para executar o exercício 5 - digite 5");
                Console.WriteLine("para sair digite 0");

                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        Console.WriteLine("Thank you for using my system!");
                        break;
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                    case 5:
                        Exercicio5();
                        break;
                    default:
                        Console.WriteLine("a opção é inválida");
                        break;
                }

            } while (option != 0);

        }
    }
}