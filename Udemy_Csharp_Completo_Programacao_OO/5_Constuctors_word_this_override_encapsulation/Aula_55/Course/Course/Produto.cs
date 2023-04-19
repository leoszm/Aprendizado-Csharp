using System;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto(){
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if(nome!=null && nome.Length > 1)
            {
                _nome = nome;
            }
        }

        public double GetPreco()
        {
            return _preco;
        }
        public int GetQuantidade()
        {
            return _quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        //método publico
        //override indica que essa operação veio de outra classe
        //string que é o tipo de saída da função
        //ToString é o nome da função
        public override string ToString()
        {
            return _nome
                + ", R$"
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + _quantidade
                + " unidades, Total: R$"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        //void significa vazio, indicando que não vai retornar nada como saída
        public void AdicionarProduto(int quantidade)
        {
            _quantidade += quantidade;//Quantidade = Quantidade + quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            _quantidade -= quantidade;//Quantidade = Quantidade - quantidade;
        }
    }
}
