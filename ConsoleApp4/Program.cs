using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraBasica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual Operação deseja fazer? :");
            Console.WriteLine("1- Adição");
            Console.WriteLine("2-Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão \n");//ao usar \n iral saltar +1 linha abaixo

           

            int operacao = int.Parse(Console.ReadLine()); //int.parse e para converter string\console, para aceitar numeros inteiro

            Console.WriteLine("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            switch (operacao)
            {
                case 1:
                    {
                        resultado = Adicao(num1, num2);
                        break;
                    }
                case 2:
                    {
                        resultado = Subtracao(num1, num2);
                        break;
                    }
                case 3:
                    {
                        resultado = Multiplicacao(num1, num2);
                        break;
                     }
                case 4:
                    {
                        resultado = Divisao(num1, num2);
                        break;
                    }
                    //DEFAULT E PRA RETORNAR UMA MENSAGEM CASO NENHUM DO NUMERO CITADOS/USADOS ACIMA FOR USADO 
                default:
                    Console.WriteLine("Numero invalido Digite um novo numero.");
                    break;
            }
            Console.WriteLine("O resultado da operação com os números {0} e {1} é:{2}",num1, num2, resultado);
            Console.ReadLine();        
        }






        //OS METODOS DE CADA OPERAÇÃO ABAIXO  USADOS PARA REALIZAR A OPERAÇÃO E RETORNAR COM O VALOR
        public static int Adicao (int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }
        
        public static int Subtracao (int num1, int num2)
        {
            int resultado = num1 - num2;
            return resultado;
        }
        
        public static int Multiplicacao (int num1, int num2)
        {
            int resultado = num1 * num2;
            return resultado;
        }
        
        public static int Divisao (int num1, int num2)
        {
            int resultado = num1 / num2;
            return resultado;
        }
        
    }
}
