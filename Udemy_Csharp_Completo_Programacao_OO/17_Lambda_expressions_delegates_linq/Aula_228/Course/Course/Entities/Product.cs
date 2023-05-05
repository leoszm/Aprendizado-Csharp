using System.Globalization;

namespace Course.Entities
{

    //Classe product implementa classe Genérica de IComparable
    class Product /*: IComparable<Product>*/
    {

        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        //Comparando o nome de um produto com o outro pelo nome desconsiderando maiúsculas e minúsculas
        //public int CompareTo(Product other)
        //{
        //    //Convertendo para letra maiúscula
        //    return Name.ToUpper().CompareTo(other.Name.ToUpper());
        //}
    }
}
