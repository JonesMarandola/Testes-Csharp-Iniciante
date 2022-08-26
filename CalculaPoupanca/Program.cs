using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10");

        double investimento = 1000;

        //rendimento 0.5% (0.005) mês

        int mes = 1;

        while(mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você têm " + investimento);

            mes ++;
        }


        Console.WriteLine("Tecle enter 2x para fechar...");
        Console.ReadLine();
    }

}
