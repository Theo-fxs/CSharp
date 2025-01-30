using System;


public class Exercicio16Correcao
{
        public static void Main(string[] args)
        {

        parImpar(10);
        parImpar(11);

        }

    public static void parImpar(int valor1)
    {
        bool resultado = valor1 % 2 == 0;

        if (resultado)
        {
            quadradoNumPar(valor1);

        }
        else
        {
            Console.WriteLine("O numero nao e impar e por " +
                "isso nao e calculado o valor e quadrado ");
        }
    }
    public static void quadradoNumPar(int valor2)
    {
        int resultado = valor2 * valor2;
        Console.WriteLine("O quadrado do valor " + valor2 + " e " + resultado);
    }



}

