using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipos de variáveis
            bool ceuAzul = true;
            bool ceuMarrom = false;
            char genero = 'F';
            char unicode = '\u0041';
            string nome = "Maria Green";
            nome = "Maria Purple";
            object obj1 = "Alex Brown";
            object obj2 = 4.5F;

            //Limites
            sbyte menorSBYTE = sbyte.MinValue;
            sbyte maiorSBYTE = sbyte.MaxValue;
            byte menorByte = byte.MinValue;
            byte maiorByte = byte.MaxValue;
            int menorInt = int.MinValue;
            int maiorInt = int.MaxValue;
            long menorLong = long.MinValue;
            long maiorLong = long.MaxValue;
            float menorFloat = float.MinValue;
            float maiorFloat = float.MaxValue;
            double menorDouble = double.MinValue;
            double maiorDouble = double.MaxValue;


            sbyte x = 100;
            byte n1 = 255;
            int n2 = 2147483647;
            long n3 = 2147483648L;
            float n4 = 4.5F;
            double n5 = 4.5;

            Console.WriteLine("tipos de variaveis:\n");
            Console.WriteLine("tipo bool ceu azul = " + ceuAzul);
            Console.WriteLine("tipo bool ceu marrom = " + ceuMarrom);
            Console.WriteLine("tipo char genero é " + genero);
            Console.WriteLine("tipo char unicode letra u0041 é " + unicode);
            Console.WriteLine("tipo sbyte(-128 - 127) = " + x);
            Console.WriteLine("tipo byte(-255 - 255) = " + n1);
            Console.WriteLine("tipo int(<=2147483647) = " + n2);
            Console.WriteLine("tipo long(>=2147483648) = " + n3);
            Console.WriteLine("tipo float = " + n4);
            Console.WriteLine("tipo double = " + n5);
            Console.WriteLine("\n\n\nSeus Limites:\n");
            Console.WriteLine("Menor sbyte = " + menorSBYTE);
            Console.WriteLine("Maior sbyte = " + maiorSBYTE);
            Console.WriteLine("Menor byte = " + menorByte);
            Console.WriteLine("Maior byte = " + maiorByte);
            Console.WriteLine("Menor Int = " + menorInt);
            Console.WriteLine("Maior Int = " + maiorInt);
            Console.WriteLine("Menor Long = " + menorLong);
            Console.WriteLine("Maior Long = " + maiorLong);
            Console.WriteLine("Menor Float = " + menorFloat);
            Console.WriteLine("Maior Float = " + maiorFloat);
            Console.WriteLine("Menor Double = " + menorDouble);
            Console.WriteLine("Maior Double = " + maiorDouble);
        }
    }
    #region Comentarios
    //SBYTE == sbyte: SBYTE pertence ao system do .Net, enquanto o sbyte já é prédefinido do C#
    //Se estrapolar o limite da variável, ela vai para o valor oposto exemplo byte: 255 -> 0; sbyte: 127 -> -128
    //UNICODE é utilizado como o código dos caracteres
    //string é um tipo imutavel e seguro, assim sendo você não muda o original, você cria um novo string e atribui ele a variável
    //object é um objeto generico, toda classe c# pertence a um object
    #endregion
}