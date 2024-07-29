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
            Console.WriteLine(" ");
            Console.WriteLine("Entre um valor para depósito inicial: ");
            c.Saldo = double.Parse(Console.ReadLine());
        }

        Console.WriteLine(" ");
        Console.WriteLine("Dados da conta:");
        Console.WriteLine($"Conta {c.Numero}, Titular: {c.Titular}, Saldo: $ {c.Saldo}");
        
        Console.WriteLine(" ");
        Console.Write("Entre um valor para depósito: ");
        c.Saldo = double.Parse(Console.ReadLine());
        
        Console.WriteLine(" ");
        Console.WriteLine("Dados da conta: Atualizados:");
        Console.Write($"Conta {c.Numero}, Titular: {c.Titular}, Saldo: $ {c.Saldo}");

        Console.WriteLine(" ");
        Console.Write("Entre um valor para saque: ");
        double valor = double.Parse(Console.ReadLine());
        c.Saque(valor);
        
        Console.WriteLine(" ");
        Console.WriteLine("Dados da conta: Atualizados:");
        Console.Write($"Conta {c.Numero}, Titular: {c.Titular}, Saldo: $ {c.Saldo}");
        
    }
    
}