using System;
using System.Collections.Generic;
using Course.Entities;

namespace Course {

    #region parte 1 - Ordenar a lista
    //class Program {
    //    static void Main(string[] args) {

    //        //Lista de produtos
    //        List<Product> list = new List<Product>();

    //        //Adicionando 3 produtos
    //        list.Add(new Product("TV", 900.00));
    //        list.Add(new Product("Notebook", 1200.00));
    //        list.Add(new Product("Tablet", 450.00));

    //        //Ordenar a lista
    //        list.Sort();

    //        //Imprimir os produtos
    //        foreach (Product p in list) {
    //            Console.WriteLine(p);
    //        }
    //    }
    //}
    #region Comentários

    /*
     * Comparison<T>
     */
    #endregion
    #endregion

    #region Parte 2 - Dinamizar o programa, para que não tenha de alterar a classe para fazer comparação, e sim o elemento

    /*class Program
    {
        static void Main(string[] args)
        {

            //Lista de produtos
            List<Product> list = new List<Product>();

            //Adicionando 3 produtos
            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            //Uma variável que guarda a referência para uma função
            Comparison<Product> comp = CompareProducts;

            //Ordenar a lista usando a referência de um método, sem passar os parametros como argumentos entre parenteses, exemplo de um Delegate
            //list.Sort(CompareProducts);

            //Recebe essa referência como argumento da função sort
            list.Sort(comp);

            //Imprimir os produtos
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
        //Método auxiliar que compara 2 produtos
        static int CompareProducts(Product p1, Product p2){
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
    }*/
    #region Comentários
    //Delegate é uma referência para função com type Safety
    /*
     * Comparison<T> é um Delegate
        - Sua declaração é realizada desta forma:
            . public delegate int Comparison<in T>(T x, T y);
            . public delegate int Comparison do tipo T recebendo 2 objetos do tipo T
            . Comparison é genérico e retorna um tipo inteiro
     * 
     */
    #endregion
    #endregion

    #region Parte 3 - Passar o CompareProducts como função lambda

    class Program
    {
        static void Main(string[] args)
        {

            //Lista de produtos
            List<Product> list = new List<Product>();

            //Adicionando 3 produtos
            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            //Não precisa declarar objetos como tipo Product, eles são inferidos, e após eles colocar a seta de função que será a expressão resultante desses dois argumentos
            //Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

            //Recebe essa referência como argumento da função sort
            //list.Sort(comp);

            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            //Imprimir os produtos
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

    }

    #endregion
}
