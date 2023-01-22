using System;
using System.Globalization;


namespace Projeto01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op, v1I, v2I, v3I, v4I, totalI, idFu;
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
                    Console.WriteLine("Código do Funcionário; ");
                    idFu = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nome do funcionário; ");
                    string Nome = Console.ReadLine();
                    Console.WriteLine("Valor hora; ");
                    v2D = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.WriteLine("Horas trabalhadas; ");
                    v1I= int.Parse(Console.ReadLine());
                    totalD = v2D * v1I;
                    Console.WriteLine("Olá, " +Nome+ ", seu código é " +idFu+ ", trabalhastes " +v1I+ " hora(s), seu valor hora é " +v2D+ ". O seu total a receber será; " +totalD.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 5:
                    Console.WriteLine("--x-- Soma produtos --x--");
                    Console.WriteLine("Código do produto 1; ");
                    v1I = int.Parse(Console.ReadLine());
                    Console.WriteLine("quantidade; ");
                    v2I = int.Parse(Console.ReadLine());
                    Console.WriteLine("Valor unitário; ");
                    v1D = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Código do produto 2; ");
                    v3I = int.Parse(Console.ReadLine());
                    Console.WriteLine("quantidade; ");
                    v4I = int.Parse(Console.ReadLine());
                    Console.WriteLine("Valor unitário; ");
                    v2D = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    totalI = v2I + v4I;
                    totalD = v2I * v1D + v4I * v2D;
                    Console.WriteLine("COD.  |  QTD.  |  Valor Unit.");
                    Console.WriteLine(v1I + "   |   " + v2I + "   |   " + v1D);
                    Console.WriteLine(v3I + "   |   " + v4I + "   |   " + v2D);
                    Console.WriteLine("");
                    Console.WriteLine("total itens " + totalI);
                    Console.WriteLine("TOTAL " + totalD);
                    break;
                case 6:
                    Console.WriteLine("--x-- Calculo triângulo --x--");


                    break;
            }
            Console.WriteLine("Pressione qualquer tecla para encerrar.");
            Console.ReadLine();

        }
    }
}
