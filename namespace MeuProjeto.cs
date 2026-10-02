using System;

namespace MeuProjeto
{
    class Program
    {
        enum Opcao 
        { 
            Somar = 1, 
            Subtrair = 2, 
            Multiplicar = 3, 
            Dividir = 4, 
            Potencia = 5, 
            Sair = 6 
        }

        static void Main(string[] args)
        {
            Opcao opcao;

            do
            {
                Console.WriteLine("\n===== CALCULADORA =====");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("5 - Potencia");
                Console.WriteLine("6 - Sair");
                Console.Write("Escolha uma opcao: ");

                opcao = (Opcao)Convert.ToInt32(Console.ReadLine());

                if (opcao != Opcao.Sair)
                {
                    Console.Write("Digite o primeiro numero: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite o segundo numero: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    switch (opcao)
                    {
                        case Opcao.Somar:
                            ExibirResultado("soma", Somar(num1, num2));
                            break;
                        case Opcao.Subtrair:
                            ExibirResultado("subtracao", Subtrair(num1, num2));
                            break;
                        case Opcao.Multiplicar:
                            ExibirResultado("multiplicacao", Multiplicar(num1, num2));
                            break;
                        case Opcao.Dividir:
                            if (num2 != 0)
                            {
                                ExibirResultado("divisao", Dividir(num1, num2));
                            }
                            else
                            {
                                Console.WriteLine("Erro: Nao e possivel dividir por zero!");
                            }
                            break;
                        case Opcao.Potencia:
                            ExibirResultado("potencia", Potencia(num1, num2));
                            break;
                    }
                }

            } while (opcao != Opcao.Sair);
            
            Console.WriteLine("Programa finalizado. Ate logo!");
        }

        static double Somar(double num1, double num2) => num1 + num2;
        static double Subtrair(double num1, double num2) => num1 - num2;
        static double Multiplicar(double num1, double num2) => num1 * num2;
        static double Dividir(double num1, double num2) => num1 / num2;
        static double Potencia(double num1, double num2) => Math.Pow(num1, num2);

        static void ExibirResultado(string operacao, double resultado)
        {
            Console.WriteLine($"Resultado da {operacao}: {resultado}");
        }
    }
}