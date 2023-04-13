using System;

namespace Couse
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Parte 1
            /*
            int x = 10;

            Console.WriteLine("Bom dia!");

            if(x > 5)
            {
                Console.WriteLine("Boa tarde");
            }

            Console.WriteLine("Boa noite!");
            */
            #endregion

            #region Parte 2
            /*
            Console.WriteLine("Entre com um número inteiro:");
            int x = int.Parse(Console.ReadLine());

            if(x % 2 == 0 && x % 1 == 0)
            {
                Console.WriteLine("é um número par");
            }
            else
            {
                Console.WriteLine("é um número ímpar");
            }
            */
            #endregion

            #region Parte 3
            Console.WriteLine("Qual é a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if(hora < 12 && hora >= 6)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora >= 12 && hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else if (hora >= 18 && hora <= 24)
            {
                Console.WriteLine("Boa noite!");
            }
            else if (hora >= 0 && hora < 6)
            {
                Console.WriteLine("Boa madrugada!");
            }
            else
            {
                Console.WriteLine("Erro\nDigite um número entre 0 - 24");
            }
            #endregion
        }
    }
}