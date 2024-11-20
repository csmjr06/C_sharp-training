using System;

namespace Exe01_POO_Classes {
    internal class Program {
        static void Main(string[] args) {

            Person personA = new Person();
            Person personB = new Person();
            string maisVelho;

            Console.WriteLine("Dados da Primeira pessoa:");
            Console.Write("Nome: ");
            personA.Name = Console.ReadLine();
            Console.Write("Idade: ");
            personA.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da Segunda pessoa:");
            Console.Write("Nome: ");
            personB.Name = Console.ReadLine();
            Console.Write("Idade: ");
            personB.Age = int.Parse(Console.ReadLine());

            if (personA.Age > personB.Age) {
                maisVelho = personA.Name;
            }
            else {
                maisVelho = personB.Name;
            }
            Console.WriteLine("Pessoa mais velha: " + maisVelho);
        }
    }
}

