﻿using System;

namespace QuartosEstudantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados?");
            int n = int.Parse(Console.ReadLine());

            Estudante[] estudantes = new Estudante[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                estudantes[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < estudantes.Length; i++)
            {
                if (estudantes[i] != null)
                {
                    Console.WriteLine(i + ": " + estudantes[i]);
                }
            }

        }
    }
}
