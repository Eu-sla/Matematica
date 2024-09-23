using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace Matematica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BackgroundColor = ConsoleColor.DarkMagenta;
            ForegroundColor = ConsoleColor.Cyan;
            string opcao;
            do
            {

                Clear();
                Write(" Cálculo de Determinantes \n \n [1] Matriz 2x2 \n [2] Matriz 3x3 \n [3] Fim  \n  \n Escolha: ");
                opcao = ReadLine();
                while (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "6"
                    && opcao != "7" && opcao != "8")
                {
                    Write("\n Sua opção não é válida, por favor digite outra: ");
                    opcao = ReadLine();
                }
                switch (opcao)
                {
                    case "1":
                        {
                            dois();
                            break;
                        }
                    case "2":
                        {
                            tres();
                            break;
                        }
                    case "3":
                        {
                            //zenitpolar();
                            break;
                        }
                }
            } while (opcao != "3");
            Clear();
            Console.WriteLine("\n Obrigada por usar nosso algoritmo :)");
            Thread.Sleep(1000);
        }

        static void dois()
        {
            int[,] matriz = new int[3, 3];
            string resposta;
            do
            {
                Clear();
                Write("\n Digite os elementos da matriz:\n ");
                for(int i = 1; i <3; i++)
                {
                    for(int j = 1; j <3; j++)
                    {
                        Write("\n Digite o elemento a"+i + j+": ");
                        matriz[i, j] = int.Parse(ReadLine());
                    }
                }
                int p = (matriz[1, 1] * matriz[2, 2]);
                int s = (matriz[2, 1] * matriz[1, 2]);

                Write("\n O determinante dessa matriz é " + (p - s) + ", tendo a diagonal primária: " + p + " e a secundária: " + s);
                

                Console.WriteLine("\n Deseja fazer novamente (sim/não)? ");
                resposta = Console.ReadLine();
                while (resposta != "sim" && resposta != "s" && resposta != "Sim" && resposta != "Não" && resposta != "não" && resposta != "n" && resposta != "nao")
                {
                    Write(" \n Por favor, digite somente sim ou não \n ");
                    resposta = Console.ReadLine();
                }

            } while (resposta.ToLower() == "s" || resposta.ToLower() == "sim");
        }

        static void tres()
        {
            int[,] matriz = new int[4, 4];
            int[,] det = new int[4, 6];
            string resposta;
            do
            {
                Clear();
                Write("\n Digite os elementos da matriz:\n ");
                for (int i = 1; i < 4; i++)
                {
                    for (int j = 1; j < 4; j++)
                    {
                        Write("\n Digite o elemento a" + i + j + ":\n ");
                        matriz[i, j] = int.Parse(ReadLine());
                    }
                }
                for (int i = 1; i < 4; i++)
                {
                    for (int j = 1; j < 6; j++)
                    {
                        if (j<4)
                        {
                            det[i, j] = matriz[i, j];

                        }
                        else
                        {
                            det[i, j] = matriz[i, j-3];
                        }
                    }
                }
                int p = ((det[1, 1] * det[2, 2] * det[3,3]) + (det[1, 2] * det[2,3] * det[3, 4]) + (det[1, 3] * det[2,4] * det[3,5]));
                int s = ((det[3, 1] * det[2, 2] * det[1, 3]) + (det[3, 2] * det[2,3]* det[1, 4])+ (det[3, 3]* det[2, 4] * det[1, 5]));

                Clear();
                Write("\n O determinante dessa matriz é " + (p - s) + ", tendo a diagonal primária: " + p + " e a secundária: " + s);


                Console.WriteLine("\n Deseja continuar (sim/não)? ");
                resposta = Console.ReadLine();
                while (resposta != "sim" && resposta != "s" && resposta != "Sim" && resposta != "Não" && resposta != "não" && resposta != "n" && resposta != "nao")
                {
                    Write(" \n Por favor, digite somente sim ou não \n ");
                    resposta = Console.ReadLine();
                }

            } while (resposta.ToLower() == "s" || resposta.ToLower() == "sim");
        }
    }
}
