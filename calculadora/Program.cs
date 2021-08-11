using System;
using calculadora.Entities;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Entre com o operador");
            Console.WriteLine("1(+) 2(-) 3(*) 4(/) ");
            Console.WriteLine("--------------------");
            Console.Write(":");
            int operador = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os valores:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Calculo cal = new Calculo(a, b);
           
            double soma = cal.Operacao(operador);
            Console.WriteLine();

            Console.WriteLine("Resultado = "+soma);

        }
    }
}
