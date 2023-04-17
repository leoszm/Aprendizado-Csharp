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

            Produto p = new Produto();

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
         * This
            - É uma referência para o Próprio objeto
            - Usos Comuns:
                1. Diferenciar atributos de variáveis locais(Java)
                2. Referenciar outro construtor em um construtor
                3. Passar o próprio objeto como argumento na chamada de um método ou construtor
         */
        #endregion
    }
}