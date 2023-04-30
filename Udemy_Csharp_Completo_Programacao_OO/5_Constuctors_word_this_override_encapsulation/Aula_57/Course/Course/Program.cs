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
         * Auto Properties(propriedades autoimplementadas):
            - É uma forma simplificada de se declarar propriedades que não necessitam
              lógicas particulares para as operações get e set.
            - Quando o objeto exigir algum tipo de lógica particular, deverá ser utilizada
              a Propertie comum, explicada na aula 56 do curso da Udemy
         */
        #endregion
    }
}