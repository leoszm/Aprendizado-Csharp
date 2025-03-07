﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        //método publico
        //override indica que essa operação veio de outra classe
        //string que é o tipo de saída da função
        //ToString é o nome da função
        public override string ToString()
        {
            return Nome 
                + ", R$" 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " + Quantidade 
                + " unidades, Total: R$" 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        //void significa vazio, indicando que não vai retornar nada como saída
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;//Quantidade = Quantidade + quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;//Quantidade = Quantidade - quantidade;
        }
    }
}
