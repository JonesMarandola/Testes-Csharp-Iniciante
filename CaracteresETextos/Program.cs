using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5");
        //char usa aspas simples '', texto usa "", variavel '', 16bit
        char letra = 'a';
        Console.WriteLine(letra);

        //usar (char) e um numero x depois, usamos o modo decimal para mostrar uma letra 
        letra = (char)65; //= A
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        letra = (char)(86 + 1);
        Console.WriteLine(letra);

        //string permite escrever mais que uma letra
        string primeiraFrase = "Testando uma string aqui kkkkkkk em ";
        Console.WriteLine(primeiraFrase + 2022);

        //@ antes de "" permite listar as coisas
        string cursos = @"Cursos disponiveis: 
- Go
- C#
- Python
- Java";
        Console.WriteLine(cursos);

        Console.WriteLine("Tecle enter 2x para fechar...");
        Console.ReadLine();
    }

}