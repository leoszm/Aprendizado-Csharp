using System;

namespace Course
{
    //Classe
    class Program
    {
        //Função que inicia a execução do programa(Entry Point)
        static void Main(string[] args)
        {
            #region Parte 1
            /*
            Console.WriteLine("Digite três números separados por um espaço\ne que sejam menores que 10 e maiores\nque 0: ");
            string[] numeros = Console.ReadLine().Split(' ');
            int n1 = int.Parse(numeros[0]);
            int n2 = int.Parse(numeros[1]);
            int n3 = int.Parse(numeros[2]);

            if (n1 == 0 || n2 == 0 || n3 == 0 || n1 > 10 || n2 > 10 || n3 > 10)
            {
                Console.WriteLine("Erro!!!\nDigite valores valores conforme orientação!");
            }
            else {
                if(n1 > n2 && n1 > n3)
                {
                    Console.WriteLine("Maior = {0}", n1);
                }else if(n2 > n1 && n2 > n3)
                {
                    Console.WriteLine("Maior = {0}", n2);
                }
                else if (n3 > n1 && n3 > n2)
                {
                    Console.WriteLine("Maior = {0}", n3);
                }
            }
            */
            #endregion

            #region Parte 2
            Console.WriteLine("Digite três números separados por um espaço\ne que sejam menores que 10 e maiores\nque 0: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);
            Console.WriteLine("Maior = " + resultado);
            #endregion
        }
        static int Maior(int a, int b, int c)
        {
            int m;
            if(a > b && a > c)
            {
                m = a;
            }else if(b > c && b > a)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }
}