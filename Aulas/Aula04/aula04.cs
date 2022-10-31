using System;

class Aula04{
    static int num=0;//global estatica para estar equivalente ao método estatico
    static void Main(string[] args){
        int num2 = 0;//local desta função
        Console.WriteLine(num);
    }
    void teste(){
        int num1=0;//local desta função
        Console.WriteLine(num1);
    }
}