using System;
using System;

class Aula03{
    static void Main(string[] args){
        byte n1=10;//8 bytes(0 e 255, não tem sinal)
        int nascDia, nascMes, nascAno, cirDia, cirMes, cirAno, dtAtual, cirIdade;
        nascDia = 30;
        nascMes = 10;
        nascAno = 2000;
        cirDia = 28;
        cirMes = 10;
        cirAno = 2015;
        dtAtual = 2022;

        int idade=21;//tem sinal
        //comparação num==0     atribuição num=0;
        char   letra = 'c';
        float  valor = 5.3f;
        string nome  = "Leonardo";
        
        var aux=nome;//através da atribuição o compilador vai definir tipo da variável, não é possível alterar após isso
        cirIdade =cirAno - nascAno;

        Console.WriteLine("Prazer, me chamo " + aux + ", tenho " + idade + " anos, e você?");
        Console.WriteLine("Nasci na data "+ nascDia + "/" + nascMes + "/" + nascAno + ", realizei uma cirurgia com " + cirIdade + " anos, no dia " + cirDia+ "/" + cirMes + "/" + cirAno + ".");
    }
}