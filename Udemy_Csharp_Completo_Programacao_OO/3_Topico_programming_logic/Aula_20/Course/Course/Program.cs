using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversão implícita de tipos

            //float tem 4 bytes
            float x = 4.5f;
            //double tem 8, assim sendo, 4 cabem em 8
            double y = x;
            Console.WriteLine(y);
            //Casting
            double a =  5.1;
            float b = (float)a;
            //Erro, não é possível converter implicitamente, o compilador diz que vc pode mas pode perder dados no proceso,
            //mas usando casting você diz que tem ciência que sabe que pode perder dados
            //mas insiste que o compilador execute assim msm

            //Outra situação entre operações
            // Dois inteiros em uma divisão
            int e = 5;
            int f = 2;
            //sendo o resultado em double(decimal)
            double resultado = e / f;
            Console.WriteLine(resultado);
            //Motivo: o compilador entendeu que você quer um resultado em inteiro pois utilizou numeros inteiros
            //Para resolver isso é necessário uso de casting
            resultado = (double)e / f;
            Console.WriteLine(resultado);

        }
    }
}