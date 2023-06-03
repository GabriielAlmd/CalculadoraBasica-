using System;

namespace CalculadoraBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usuario ira entrar com DOIS numeros 
            Console.WriteLine("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            //Usuario ira entrar com a OPERAÇÃO DESEJADA EX:divisão,multiplicação..etc
            Console.WriteLine("Escolha a operação: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            
            int op = int.Parse(Console.ReadLine());

            //Ira declarar uma variável para armazenar o resultado da Operação
            double resultado = 0;

            // Usar um switch para executar a operação escolhida. Cada case bloco deve terminar ...
            //com um break instrução que encerra a switch instrução.
            switch (op)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    resultado = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }

            // Imprimir o resultado na tela apos aperta ENTER
            Console.WriteLine("O resultado é: " + resultado);
        }
    }
}
