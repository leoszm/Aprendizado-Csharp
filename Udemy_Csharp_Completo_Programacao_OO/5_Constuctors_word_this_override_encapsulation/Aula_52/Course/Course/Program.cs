using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p1 = new Produto(nome, preco, quantidade);
            Produto p2 = new Produto(nome, preco);
            Produto p3 = new Produto(nome);
            Produto p4 = new Produto();

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Dados do produto: " + p1);
            Console.WriteLine("-------------------------------------------------------------");
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p1);
            Console.WriteLine("-------------------------------------------------------------");
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p1);
            Console.WriteLine("-------------------------------------------------------------");
        }
        #region Comentários
        /*
         * Sobrecarga:
            - É um recurso que uma classe possui de oferecer mais de uma operação
                com o mesmo nome, porém com diferentes listas de parâmetros;
            - Apenas o construtor pode ter sobrecarga;
         */
        #endregion
    }
}