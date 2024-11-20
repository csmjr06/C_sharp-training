
using System.Globalization;
Console.WriteLine("Entre com um número de divisões: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++) {
    Console.WriteLine("Entre com dois números: ");
    string[] list = Console.ReadLine().Split(' ');
    double a = double.Parse(list[0], CultureInfo.InvariantCulture);
    double b = double.Parse(list[1], CultureInfo.InvariantCulture);
    if (b == 0) {
        Console.WriteLine("divisão impossível");
    } else {
        double div = a / b;
        Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
    }
}
