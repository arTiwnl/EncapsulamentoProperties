using System;

namespace Exercicio;

class Program
{
    static void Main(string[] args)
    {

        Conta c;
        c = new Conta();

        string Entrada;

        Console.Write("Entre o número da conta: ");
        c.Numero = int.Parse(Console.ReadLine());

        Console.Write("Entre o titular da conta: ");
        c.Titular = Console.ReadLine();

        Console.Write("Haverá Deposíto inicial (s/n)? ");
        Entrada = Console.ReadLine();
        
        if (Entrada == "s")
        {
            Console.WriteLine("Entre um valor para depósito inicial: ");
            c.Saldo = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Dados da Conta:");
        Console.Write($"Conta {c.Numero}, Titular: {c.Titular}, Salto: $ {c.Saldo}");

        
    }
    
}