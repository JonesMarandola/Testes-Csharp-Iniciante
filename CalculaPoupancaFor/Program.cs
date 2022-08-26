using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11");

        double investimento = 1000;

        for(int mes = 1; mes <= 12; mes++)
        {
            //investimento = investimento + investimento * 0.005;
            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + " você têm " + investimento);
        }

        Console.WriteLine("Tecle enter 2x para fechar...");
        Console.ReadLine();
    }

}
