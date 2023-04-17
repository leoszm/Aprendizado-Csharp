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

            Produto p = new Produto(nome, preco, quantidade);

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
         *Construtor:
            - é uma operação especial de classe, que executa no momento 
                da instanciação do objeto;
            - Usos Comuns:
                1. Iniciar valores dos atributos;
                2. Permitir ou obrigar que o objeto receba dados/dependências
                    no momento de sua instanciação(injeção de dependência);
            - Se um construtor customizado não for especificado, a classe
                disponibiliza o construtor padrão:
                1. exemplo: Produto p = new Produto();
            - Também é possível especificar mais de um construtor na mesma 
                classe(sobrecarga);
         
         
         
         */

        #endregion
    }
}