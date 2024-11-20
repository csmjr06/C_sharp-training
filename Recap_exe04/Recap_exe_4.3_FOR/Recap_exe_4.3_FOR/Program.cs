using System.Globalization;

Console.WriteLine("Entre o no. de caso de testes: ");
int n = int.Parse(Console.ReadLine()); ;

for (int i = 0; i < n; i++) {
    Console.Write("Entre 3 valores: ");
    string[] list = Console.ReadLine().Split(' ');
    double a = double.Parse(list[0], CultureInfo.InvariantCulture);
    double b = double.Parse(list[1], CultureInfo.InvariantCulture);
    double c = double.Parse(list[2], CultureInfo.InvariantCulture);
    double media = (a * 2 + b * 3 + c * 5 )/10 ;
    Console.WriteLine("A media ponderada é: " + media.ToString("F1", CultureInfo.InvariantCulture));
}