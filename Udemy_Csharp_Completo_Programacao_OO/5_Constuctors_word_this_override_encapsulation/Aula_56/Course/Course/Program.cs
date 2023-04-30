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
         * Propriedades
            - São definições de métodos encapsulados, porém expondo uma sintaxe similar
              à de atributos e não de métodos
            - Uma propriedade é um membro que oferece um mecanismo flexível para ler,
              gravar ou calcular o valor de um campo particular. As propriedades podem
              ser usadas como se fossem atributos públicos, mas na verdade elas são
              métodos especiais chamados "acessadores". Isso permite que os dados
              sejam acessados facilmente e ainda ajuda a promover a segurança e a
              flexibilidade dos métodos.
         */
        #endregion
    }
}