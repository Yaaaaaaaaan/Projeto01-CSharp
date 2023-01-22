using System;
using System.Globalization;


namespace Projeto01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op, v1I, v2I, v3I, v4I, totalI;
            double pi, v1D, v2D, totalD;

            Console.WriteLine("");
            Console.WriteLine("--x-- Exercício 01 Estrutura sequencial --x--");
            Console.WriteLine("Olá, selecione a operação digitando o número correspondente; ");
            Console.WriteLine("1 - para soma");
            Console.WriteLine("2 - para calcular área");
            Console.WriteLine("3 - para diferença de A*B - C*D");
            Console.WriteLine("4 - para calcular salário");
            Console.WriteLine("5 - para soma produtos");
            Console.WriteLine("6 - para calculo triângulo");
            op = int.Parse(Console.ReadLine());
            switch(op){
                default: 
                    Console.WriteLine("O valor inserido está incorreto! ");
                    break;
                case 1:
                    Console.WriteLine("--x-- Soma --x--");
                    Console.WriteLine("Insira o primeiro valor; ");
                    v1I = int.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o segundo valor;");
                    v2I = int.Parse(Console.ReadLine());
                    totalI = v1I + v2I;
                    Console.WriteLine("O cálculo total é; " + v1I + " + " + v2I + " = " + totalI);
                break;
                case 2:
                    Console.WriteLine("--x-- Calcular área --x--");
                    Console.WriteLine("Insira o valor do raio do círculo; ");
                    v1D = int.Parse(Console.ReadLine());
                    pi = 3.14159;
                    totalD = pi * v1D * v1D;
                    Console.WriteLine("o calculo total é; " + pi + " * " +v1D+ " * " + v1D + " = " + totalD);
                    break;
                case 3:
                    Console.WriteLine("--x-- Diferença de A*B - C*D --x--");
                    Console.WriteLine("Insira o primeiro valor; ");
                    v1I = int.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o segundo valor; ");
                    v2I = int.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o terceiro valor; ");
                    v3I = int.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o quarto valor; ");
                    v4I = int.Parse(Console.ReadLine());
                    totalI = v1I * v2I - v3I * v4I;
                    Console.WriteLine("O calculo total é; " + v1I + " * " +v2I+ " - " +v3I+ " * " +v4I+ " = " + totalI);
                    break;
                case 4:
                    Console.WriteLine("--x-- Calcular salário --x--");

                    
                    break;
                case 5:
                    Console.WriteLine("--x-- Soma produtos --x--");


                    break;
                case 6:
                    Console.WriteLine("--x-- Calculo triângulo --x--");


                    break;
            }
            Console.WriteLine("Aperte qualquer botão para encerrar.");
            Console.ReadLine();

        }
    }
}
