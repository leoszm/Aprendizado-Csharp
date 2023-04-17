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

            /*causou erro devido ao construtor de 2 argumentos gerados, não permitindo a chamada nula(padrao)
            e nao permitindo livremente
            *para Consertar é necessário criar construtor vazio na classe produto;
            *
            Produto p = new Produto();

            Produto p5 = new Produto
            {
                Nome = "TV",
                Preco = 500.00,
                Quantidade = 20
            };
            */
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
         * Sobrecarga:
            - É um recurso que uma classe possui de oferecer mais de uma operação
                com o mesmo nome, porém com diferentes listas de parâmetros;
            - Apenas o construtor pode ter sobrecarga;
         */
        #endregion
    }
}