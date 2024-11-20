// Fazer um programa para ler os valores da largura e altura de um retângulo.
// Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal.
// Usar uma classe como mostrado no projeto ao lado.

using System.Globalization;

namespace exe01_POO_Methods {
    internal class Program {
        static void Main(string[] args) {
            
            Retangulo R = new Retangulo();
            
            Console.WriteLine("Entre a largura e altura do retângulo:");
            Console.Write("Largura: ");
            R.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            R.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("AREA = " + R.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + R.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + R.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
