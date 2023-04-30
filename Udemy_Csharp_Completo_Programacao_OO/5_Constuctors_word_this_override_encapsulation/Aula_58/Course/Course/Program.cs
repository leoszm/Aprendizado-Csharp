using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);
            Console.WriteLine(p.Nome);
            /*
             * A mesma propriedade da o Get do nome abaixo e caso esteja dentro do
             * Permitido, dá o set
            */
            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
        }
        #region Comentários
        /*
         * Ordem sugerida para implementação de membros de classe:
            - Atributos privados.
            - Propriedades autoimplementadas.
            - Construtores.
            - Propriedades customizadas.
            - Outros métodos da classe.
            - 
         */
        #endregion
    }
}