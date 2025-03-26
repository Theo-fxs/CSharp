using System;
public class Exercicio20
{
 public static void Main(string[] args)
        {
        double numerodecimal = 1.99;
        int conversao = Convert.ToInt32(numerodecimal);
        Console.WriteLine("O valor convertido é: " + conversao); // Aqui vai mostrar 2 pois o convert.toint32() arredonda o valor para cima

        long numerolong = 1000000000000000; // esse numero e o numero long ja convertado para int
        int numeroshort = (int) numerolong;// deu erro pois o numero long e muito grande para ser convertido para int
        Console.WriteLine("O valor short é: " + numeroshort);

        char letra = 'J';
        int letraconvertida = Convert.ToInt32(letra);
        Console.WriteLine("O valor convertido é: " + letraconvertida); // Aqui vai mostrar 74 pois o convert.toint32() pega o valor da tabela ascii

        byte numerobyte = 255;
        int numeroconvertido = Convert.ToInt32(numerobyte);
        Console.WriteLine("O valor convertido é: " + numeroconvertido); // Aqui vai mostrar 255 pois o convert.toint32() pega o valor do byte

        double numerodouble = 1.99;
        float numerofloat = (float)numerodouble;
        Console.WriteLine("O valor convertido é: " + numerofloat); // Aqui vai mostrar 1.99 pois o (float) converte o valor para float

    }
    
}
