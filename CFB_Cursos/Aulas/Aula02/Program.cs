using System;
//System é uma biblioteca que possui controle de vari�veis, I/O, impress�o de mensagens, limpeza.
namespace Program{
    class Principal
    {
        //método principal da classe
        static void Main(string[] args)
        {
            //Enviar para saída a mensagem Ol� Mundo...
            Console.Write("CFB Cursos\n");
            //tratativa de erro
            if(args.GetLenght(0)>0){
                //Enviar para a saída o parametro digitado pelo dev após program na posição 0, ex: .\program b retornará b
                Console.Write(args.GetValue(0));
            }
        }
    }
}