using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 - Criando Variáveis");

        int idade; //int aceita apenas valores inteiros
        idade = 21;

        Console.WriteLine("Minha idade é " + idade);

        idade = 27 - 5;

        Console.WriteLine("27 - 5 = " + idade);

        idade = (5 * 2) - 6;

        Console.WriteLine("(5 * 2) - 6 = " + idade);

        Console.WriteLine("Tecle enter 2x para fechar...");
        Console.ReadLine();

    }

}
