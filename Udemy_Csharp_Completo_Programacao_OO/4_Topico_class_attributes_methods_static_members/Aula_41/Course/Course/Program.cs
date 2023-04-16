using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();


            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //areaX = triângulo(classe) x(com valores a,b,c) fazendo a operação de Area
            double areaX = x.Area();
            //areaY = triângulo(classe) Y(com valores a,b,c) fazendo a operação de Area
            double areaY = y.Area();

            Console.WriteLine("A area do triangulo X é " + areaX.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine("A area do triangulo Y é " + areaY.ToString("F4"), CultureInfo.InvariantCulture);

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área X");
            }
            else
            {
                Console.WriteLine("Maior área Y");
            }
        }
    }
}
