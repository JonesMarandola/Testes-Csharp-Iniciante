using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7");

        int idadeJoao = 16;
        int idadeObrigatoria = 18;
        int quatidadePessoas = 2;

        if (idadeJoao >= idadeObrigatoria)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            if (quatidadePessoas > 0)
            {
                Console.WriteLine("Ele está acompanhado de maiores, pode entrar!");
            }
            else
            {
                Console.WriteLine("Proibido entrada de menores de 18 anos!");
            }

        }

        Console.WriteLine("Tecle enter 2x para fechar...");
        Console.ReadLine();
    }

}

