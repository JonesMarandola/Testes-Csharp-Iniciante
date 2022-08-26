using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 3");
        //double aceita valores com virgula e valores inteiros
        double salario;
        salario = 3000.13;

        salario = 3000;

        double idade;

        //temos que colocar 7.0 pq ele desconsidera o numero após a virgula, não mostrando o real resultado
        idade = 7.0 / 5; 
        

        Console.WriteLine(salario);
        Console.WriteLine(idade);

        Console.WriteLine("Tecle enter 2x para fechar...");
        Console.ReadLine();
    }

}
