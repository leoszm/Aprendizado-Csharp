using System;
using System.Numerics;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Parte 1
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            int n4 = 10 / 8;

            double n5 = (double)10 / 8;//*Aula de Casting explica isso
            //ou
            double n6 = 10.0 / 8;//10.0 auto indica que é um decimal, trazendo do tipo int para o double, tanto faz o 10.0 como o 8 ser também decimal 


            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);//*Aula de Casting explica isso
            Console.WriteLine("---------------------------------------");
            #endregion

            #region Parte 2
            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b,2.0) - (4 * a * c);
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine("Bhaskara");
            Console.WriteLine("Os valores sendo a = " + a.ToString("F2") + ", b = " + b.ToString("F2") + " e c = " + c.ToString("F2") + " resultam em delta sendo " + delta.ToString("F2") + " e x1 = " + x1.ToString("F2") + " e x2 = " + x2.ToString("F2") + "." );
            #endregion

        }
        #region Comentarios
        //as contas priorizadas sõ as de multiplicação e divisão, para sobrescrever elas,
        //caso sua função siga por outro primeiro passo, é necessário colocar a conta de
        //seu desejo dentro de parenteses

        //contas com % retornará o resto da divisão

        //se você solicitar retorno de 2 ints ou a variavel de resultado for um int, a
        //resposta será um numero inteiro, pra a resposta ser um decimal correto, deverá
        //ser feita uma variável para resposta tipo double e ao menos 1 das variáveis
        //deverá ser float ou double
        #endregion
    }
}