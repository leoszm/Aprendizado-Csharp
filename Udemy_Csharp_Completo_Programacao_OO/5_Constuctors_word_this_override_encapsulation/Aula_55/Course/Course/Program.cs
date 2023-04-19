using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            Console.WriteLine(p.GetNome());//TV
            Console.WriteLine("Escreva um novo nome");
            p.SetNome("TV 4K");//Alterando
            Console.WriteLine(p.GetNome());//TV 4K
        }
        #region Comentários
        /*
         * Encapsulamento:
            - É um princípio que consiste em esconder detalhes de implementação de um
              componente, expondo apenas operações seguras e que o mantenha em um
              estado consistente.
            - Regra de ouro: o objeto deve sempre estar em um estado consistente, e a
              própria classe deve garantir isso.
         */
        #endregion
    }
}