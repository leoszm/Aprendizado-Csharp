using System;
using System.Globalization;
using System.Reflection.Metadata;

namespace Course
{
    class Program 
    { 
        static void Main(string[] args)
        {

            #region Parte 1 da aula
            /*
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";
            char genero = 'F';

            //escreve na linha porém sem quebra
            Console.Write("Bom dia!");
            //escreve na linha com quebra
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("" +
                "Bom dia " + nome + ", hoje é seu aniversário de " + idade + " anos, \nvocê acabou de receber " +
                "um multiplicador da \n" + "sua renda do banco em " + saldo.ToString("F2") + "(arrendondando pra " +
                "duas casas, \nou " + saldo.ToString("F4") + " arrendondando para quatro casas) só confirme se \n" +
                "seu genero é " + genero
            );
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));//ao invés de virgula, utiliza ponto
            */
            #endregion

            #region Parte 2
            /*
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";
            //Placeholder
            Console.WriteLine("Placeholder\n{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            //                                                      ou                          saldo.ToString("F4")

            //Interpolação
            Console.WriteLine($"Interpolação\n{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

            //Concatenação
            Console.WriteLine("Concatenação\n" + nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais");
            */
            #endregion

            #region Exercicio para fixacao

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine(produto1 + ", cujo preço é $ " + preco1.ToString("F2"));
            Console.WriteLine(produto2 + ", cujo preco é $ " + preco2.ToString("F2"));
            Console.WriteLine("");
            Console.WriteLine("Registro: " + idade + " anos de idade, código " + codigo + " e gênero: " + genero);
            Console.WriteLine("");
            Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F8"));
            Console.WriteLine("Arrendondado (três casas decimais): " + medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

            #endregion
        }
    }
    #region Comentarios
    //atalho: "cw" + Tab + Tab auto escreve um Console.WriteLine();
    //CultureInfo.InvariantCulture elimina qualquer formatação dos paises em si, deixando da maneira global
    #endregion  
}