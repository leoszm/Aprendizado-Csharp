using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Errado variável x estar sendo chamada no WriteLine
             * sem ter sido atribuído nenhum valor.
          
            int x;
            Console.WriteLine(x);
            */

            /* Errado devido a variável desconto estar sendo declarada dentro
             * da estrutura, fora da estrutura ela não existe...
             
             * De maneira técnica, o escopo maior(função, projeto, etc)
             * não reconhece escopo menor, ja o escopo menor 
             * reconhece o maior...
             
            double preco = double.Parse(Console.ReadLine());
            if (preco > 100.0)
            {
                double desconto = preco * 0.1;
            }
            Console.WriteLine(desconto);
            */
        }
    }
}