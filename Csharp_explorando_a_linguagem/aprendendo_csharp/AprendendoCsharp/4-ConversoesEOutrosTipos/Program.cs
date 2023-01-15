using System;

class Program
{

    static void Main(string[] args)
    {
        //Declarações

        #region Definições e métricas
        //sbyte     -128 a 127                        Inteiro de 8 bits com sinal.
        //byte      0 a 255                           Inteiro de 8 bits sem sinal.
        //short     -32.768 a 32.767                  Inteiro de 16 bits com sinal.
        //ushort    0 a 65.535                        Inteiro de 16 bits sem sinal.
        //int       -2.147.483.648 a 2.147.483.647    Inteiro assinado de 32 bits.
        //uint      0 a 4.294.967.295                 Inteiro de 32 bits sem sinal.
        //long      -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807  Inteiro assinado de 64 bits.
        //ulong     0 a 18.446.744.073.709.551.615    Inteiro de 64 bits sem sinal.
        
        //float   ±1,5 x 10−45 para ±3,4 x 1038         ~6 a 9 dígitos        4 bytes.
        //double  ±5.0 × 10−324 to ±1.7 × 10308         ~15 a 17 dígitos      8 bytes.
        //decimal ±1,0 x 10 - 28 para ±7,9228 x 1028    28 a 29 dígitos       16 bytes.
        #endregion

        //O double é uma variável de 8 bits
        double salario = 3000.15;
        int salarioInteiro = (int)salario;//desconsidera o .15(arrendondando)
        long x = 2000000000000000000;
        short y = 16000;
        float altura = 1.62f;
        /*
         * Erro devido a int não aceitar double, mas double aceita int
         int salarioInteiro = salario;
        */

        //Saída
        Console.WriteLine("Projeto 4 - Outros tipos de variáveis lógicas");
        Console.WriteLine("Meu salário é de R$" + salario + " reais.");
        Console.WriteLine("Meu salário inteiro é de R$" + salarioInteiro + " reais(sem os centavos).");
        Console.WriteLine("Meu long é de " + x + ".");
        Console.WriteLine("Meu short é de " + y + ".");
        Console.WriteLine("Minha altura é de " + altura + "cm(sem trocar pra double).");

        //Fim
        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}
