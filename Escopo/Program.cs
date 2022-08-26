using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 9");

        int idadeJoao = 16;
        int idadeObrigatoria = 18;
        int quatidadePessoas = 2; //Joao e + 1

        bool acompanhado = quatidadePessoas > 1;

        string textoAdicional;

        if(acompanhado == true)
        {
            textoAdicional = "João está acompanhado";
        }
        else
        {
            textoAdicional = "João não está acompanhado";
        }

        if (idadeJoao >= idadeObrigatoria || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Maiores de 18 anos ou acompanhado de maiores, podem entrar!");
        }
        else
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Proibido entrada de menores ou desacompanhado de maiores de 18 anos!");

        }

        Console.WriteLine("Tecle enter 2x para fechar...");
        Console.ReadLine();
    }

}

