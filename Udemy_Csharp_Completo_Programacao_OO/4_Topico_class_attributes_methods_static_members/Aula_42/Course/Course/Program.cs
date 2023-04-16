using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine("-------------------------------------------------------------");
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);
            Console.WriteLine("-------------------------------------------------------------");
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);
            Console.WriteLine("-------------------------------------------------------------");

        }
        #region Comentários
        /*
        * Toda classe em C# é uma subclasse da classe Object;

        * Object possui os seguintes métodos:
            -GetType - retorna o tipo do objeto;
            -Equals - Compara se o objeto é igual a outro;
            -GetHashCode - retorna um código hash do objeto;
            -ToString - converte o objeto para string;
         */
        #endregion
    }
}