using System;
internal class Exercicio_16
{
    public static void Main(string[] args)
    {
        int numero = 10;
        bool resultado = valor(numero);
        if (resultado)
        {
            int squareroot = numero * numero;
            Console.WriteLine("Este numero e par e o quadrado e " + squareroot);   
        }
        else
        {
            Console.WriteLine("Este numero e impar");
        }
    }
    public static bool valor(int a)
    {
        return a % 2 == 0;
    } 

}