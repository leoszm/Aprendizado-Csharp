using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Parte 1
            /*
            //Operadores de atribuição
            //a RECEBE 10
            int a = 10;
            Console.WriteLine(a);
            //a RECEBE a + 2 (SOMA)
            a += 2;
            Console.WriteLine(a);
            //a RECEBE a - 2 (SUBTRAÇÃO)
            a -= 2;
            Console.WriteLine(a);
            //a RECEBE a * 2; (MULTIPLICAÇÃO)
            a *= 2;
            Console.WriteLine(a);
            //a RECEBE a /2; (DIVISÃO)
            a /= 2;
            Console.WriteLine(a);
            //a RECEBE a %3; (RESTO)
            a %= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);
            s += "DEF";
            Console.WriteLine(s);
            */
            #endregion

            #region Parte 2
            //Operadores aritméticos/atribuição
            int a = 10;
            Console.WriteLine(a);
            //a = a + 1
            a++;
            Console.WriteLine(a);
            //a = a - 1
            a--;
            Console.WriteLine(a);
            Console.WriteLine("--------------------------------------");
            //MAS...
            int c = 10;
            int d = c++;
            Console.WriteLine(c);
            Console.WriteLine(d);
            //Motivo: ele atribuiu a C a atribuição feita na declaração de D
            //porém em D, primeiro foi atribuido somente o valor de C a D, e a atribuição foi passada pra C
            //Nessa situação o correto seria...
            Console.WriteLine("-------Correto-------");
            c = 10;
            d = ++c;
            Console.WriteLine(c);
            Console.WriteLine(d);
            //Motivo: em C ele vai receber o valor atribuido da incrementação
            //e em D, primeiro ele vai fazer a incrementação de C e depois atribuir a ele o resultado dessa atribuição
            #endregion
        }
        #region Comentarios
        //+= também é adição cumulativa de strings!
        #endregion
    }
}