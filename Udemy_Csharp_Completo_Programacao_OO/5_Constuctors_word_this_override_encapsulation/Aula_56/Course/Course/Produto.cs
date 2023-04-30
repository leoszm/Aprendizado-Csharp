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

        public Produto()
        {
        }

        //Substitui método GetNome e SetNome
        public string Nome
        {
            get { 
                return _nome;
            }
            /* value:
             * o objeto string nome que antes era declarado no construtor, agora
             * é declarado com nome de value, assim sendo, o valor que chega nesse set
             * é utilizado e atribuído ao objeto _nome
            */
            set { 
                if (value != null && value.Length > 1) {
                    _nome = value;
                } 
            }
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        #region Substituido GetNome e SetNome
        //public string GetNome()
        //{
        //    return _nome;
        //}

        //public void SetNome(string nome)
        //{
        //    if (nome != null && nome.Length > 1)
        //    {
        //        _nome = nome;
        //    }
        //}
        #endregion

        public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
        }
        #region Substituido GetPreco e GetQuantidade
        //public double GetPreco()
        //{
        //    return _preco;
        //}

        //public int GetQuantidade()
        //{
        //    return _quantidade;
        //}
        #endregion

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
