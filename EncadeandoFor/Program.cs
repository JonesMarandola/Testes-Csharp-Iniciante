using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 13");

        for(int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for (int contadorColunas = 0; contadorColunas < contadorLinhas; contadorColunas++)
            {
                Console.WriteLine("*");
                if (contadorColunas >= contadorLinhas)
                    break;
            }
            Console.WriteLine();
        }

        Console.WriteLine("Tecle enter 2x para fechar...");
        Console.ReadLine();
    }

}
