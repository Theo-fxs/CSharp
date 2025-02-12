using System;
public class Program
{
    public static void Main(string[] args)
    {
        // string e para texto NAO PODE USAR INT :D

        String[] cidades = { "Lisboa", "Porto", "Coimbra" ,"Faro","Braga"  };
        int[] populacao = { 545000, 237000, 143000 , 118000 , 193000 };
        Console.WriteLine("Cidades e as suas populacoes: \n ");

        // isso e uh o coiso que faz o loop :D 

        for (int contador = 0; contador < cidades.Length; contador++)
        {
            Console.WriteLine($"{cidades[contador]} - { populacao[contador]} habitantes");
        }


    }
}
