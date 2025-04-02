using System;
using System.Collections.Generic;
public class Exercicio19
{   
        public static void Main(string[] args)
        {
         List<string> listaNomes = new List<string>();
         Console.WriteLine("Insira 5 nomes : ");
        for(int contador = 0; contador < 5; contador++)
        {
            String nome = Console.ReadLine();
            listaNomes.Add(nome);
        }
        Console.WriteLine("Lista de nomes: " );
        foreach (string nome in listaNomes) {
        Console.WriteLine(nome);
        }
        listaNomes.Sort();
        Console.WriteLine("Lista de nomes organizado");
        foreach (string nome in listaNomes) {
        Console.WriteLine(nome);
        }
        
        }   
}