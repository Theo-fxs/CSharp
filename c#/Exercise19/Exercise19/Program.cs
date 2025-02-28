using System;
using System.Collections.Generic;


public class Exercise19
{
    public static void Main(string[] args)
    {
        Dictionary<String, string> Contacto = new Dictionary<String, string>();
        

        Console.WriteLine("1.Acicionar contactos \n" + "2.Pesquisar contacto \n" + "3.Remover contactos" + "4.Sair");
        Console.WriteLine("Eschola uma opcao seu preto filho da preta");
        string num = Console.ReadLine();

        switch (num) 
        {
            case "1":
                Console.WriteLine("Nome");
                String nome = Console.ReadLine();
                Console.WriteLine("Contacto");
                String contacto = Console.ReadLine();
                Console.WriteLine("Contacto adicionado");
                break;
                
            case "2":
                Console.WriteLine("Pesquisa contacto");
                string contacto1 = Console.ReadLine();
                Console.WriteLine("Contacto pesquisado");
                break;

            case "3":
                Console.WriteLine("Remover contacto");
                string contacto2 = Console.ReadLine();
                Console.WriteLine("Contacto Removado");
                break;

             case "4":
                Console.WriteLine("Sair");
                break;
        }
    }
}
