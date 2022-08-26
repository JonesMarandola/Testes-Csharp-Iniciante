using System;
class Programa
{
    static void Main(string[] args)
    {
        double salario;
        salario = 3000.15;
        Console.WriteLine(salario);


        int salarioInteiro; //sem os centavos
        salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        //int é apenas para 32bit, ou seja, não aguenta valores elevados (acima de +-2.10^32), usamos long(64bits) para contornar

        long x = 2000000000000000000;
        Console.WriteLine(x);

        //short é para valores pequenos, 16bit
        short y = 15000;
        Console.WriteLine(y);

        //trabalha com numeros com virgula, mas tem maior precisão
        float altura = 1.62f;
        Console.WriteLine(altura);

        Console.WriteLine("Tecle enter 2x para fechar...");
        Console.ReadLine();
    }

}