// Fazer um programa para ler nome e salário de dois funcionários.
// Depois, mostrar o salário médio dos funcionários.

using System;
using System.Globalization;

namespace Exe1_2_POO_Classes {
    internal class Program {
        static void Main(string[] args) {
            Employee firstEmployee = new Employee();
            Employee secondEmployee = new Employee();
            double mediaSalarial;

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            firstEmployee.Name = Console.ReadLine();
            Console.Write("Salário: ");
            firstEmployee.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            secondEmployee.Name = Console.ReadLine();
            Console.Write("Salário: ");
            secondEmployee.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            mediaSalarial = (firstEmployee.Salary + secondEmployee.Salary)/2;

            Console.WriteLine("Salário médio = R$ " + mediaSalarial.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}


