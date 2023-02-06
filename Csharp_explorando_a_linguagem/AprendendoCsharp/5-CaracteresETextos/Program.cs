using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5 - Caracteres");

        char letra = 'a';
        Console.WriteLine(letra);

        //type string 65
        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        letra = (char)(86 + 1);
        Console.WriteLine(letra);
        Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////");
        Console.WriteLine("Executando o projeto 5 - Textos");
        string primeiraFrase = "Alura - Cursos de tecnologia";
        Console.WriteLine(primeiraFrase + " 2022");

        string vazia = "";
        Console.WriteLine(vazia);

        letra = ' ';

        string cursos = "Cursos disponíveis - Go - C# - Python - Java - Perl - Ruby - Javascript";
        Console.WriteLine("1 - " + cursos);
        Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////");
        //ou
        cursos = "Cursos disponíveis" + "- Go" + "- C#" + "- Python" + "- Java" + "- Perl" + "- Ruby" + "- Javascript";
        Console.WriteLine("2 - " + cursos);
        Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////");
        //ou
        cursos = @"Cursos disponíveis 
- Go 
- C# 
- Python 
- Java 
- Perl 
- Ruby 
- Javascript
//////////////////////////////////////////////////////////////////////////////////////////";
        Console.WriteLine("3 - " + cursos);

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}