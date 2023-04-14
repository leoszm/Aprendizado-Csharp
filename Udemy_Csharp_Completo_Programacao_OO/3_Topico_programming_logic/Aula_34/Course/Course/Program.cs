using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números inteiros você vai digitar?");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;
            for(int i = 1;i <= n; i++)
            {
                Console.WriteLine("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine("O resultado é = " + soma);
        }
    }
}