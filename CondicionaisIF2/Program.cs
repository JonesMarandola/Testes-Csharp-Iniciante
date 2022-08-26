using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 8");

        int idadeJoao = 16;
        int idadeObrigatoria = 18;
        int quatidadePessoas = 2; //Joao e + 1

        bool acompanhado = quatidadePessoas > 1;

        if (idadeJoao >= idadeObrigatoria || acompanhado)
        {
            Console.WriteLine("Maiores de 18 anos ou acompanhado de maiores, podem entrar!");
        }
        else
        {
            Console.WriteLine("Proibido entrada de menores ou desacompanhado de maiores de 18 anos!");

        }

        Console.WriteLine("Tecle enter 2x para fechar...");
        Console.ReadLine();
    }

}

