using System;
public class Program
{
    public static void Main(string[] args)
    {
        // string e para texto NAO PODE USAR INT :D

        String [] ListaFilmes = {"Harry Potter" ,"Zorro" ,"Simpsons"};
        int[] Ano = {1999 , 2010 , 2014 };
        Console.WriteLine("Lista de Filmes: \n ");

        // isso e uh o coiso que faz o loop :D 

        for (int contador = 0; contador < ListaFilmes.Length; contador++)
        {
            Console.WriteLine(ListaFilmes[contador] + " - " + Ano[contador]);
        }
       

    }
}
