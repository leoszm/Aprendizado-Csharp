using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Parte 1
            /*
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.WriteLine("Você digitou : \n" + frase);
            Console.WriteLine("Você digitou : " + x);
            Console.WriteLine("Você digitou : " + y);
            Console.WriteLine("Você digitou : " + z);
            */
            Console.WriteLine("------------------------------------------");
            #endregion
            #region Parte 2
            //SPLIT(Recortar)
            //vai colocar dentro de um vetor o conteudo, mas a cada espaço em branco entre as palavras,
            //vai ir para um próximo vetor onde armazenará mais palavras
            string s = Console.ReadLine();
            string[] vet = s.Split(' ');
            //ou
            //string[] v = Console.ReadLine().Split(' ');

            //0,1,2 são as posições dentro do vetor
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine(p1 + p2 + p3);
            #endregion
        }
    }
}