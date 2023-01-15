using System;

class Program
{

    static void Main(string[] args)
    {
        //Declarações
        double salario;
        salario = 3000.10;
        double idade1, idade2;
        //Com(1) e sem ponto flutuante(2)
        idade1 = 7.0 / 5;
        idade2 = 7 / 5;
        //Saída
        Console.WriteLine("Projeto 3 - Variáveis Ponto Flutuante");
        Console.WriteLine("Minha idade com ponto flutuante é de "  + idade1 + ".");
        Console.WriteLine("Minha idade sem ponto flutuante é de " + idade2 + ".");
        Console.WriteLine("Meu salário é de R$"+ salario + " reais.");
        //Fim
        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}
