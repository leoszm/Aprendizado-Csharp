using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Volume: " + volume.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2"), CultureInfo.InvariantCulture);
        }

        #region Comentários
        /*
         * Membros estáticos:
            - Também chamados de membros de classe(atributos, métodos...);
            - São membros que fazem sentido independentemente de objetos;
            - Não precisam de objeto para serem chamados;
            - São chamados a partir do próprio nome da classe;
            - Uma classe que possui membros estáticos, pode ser uma classe
              estática também. Esta classe não poderá ser instanciada;
            - Quando não é um atributo estático, é um membro de instância;
            
            - Geralmente utilizado em: 
               1. Classes utilitárias(operações simples que podem ser chamadas
                 de forma isolada);
                    1.1 exemplo: Math.Sqrt
               2. Declaração de constantes;
         
         * Não é possível chamar uma função que não é estática de uma mesma classe
            dentro de uma função estática;
         */
        #endregion    

    }
}