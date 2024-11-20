using System;

Console.WriteLine("Entre com o valor inteiro:");
int n = int.Parse(Console.ReadLine());
int factorial = 1;

for (int i = n; i > 1; i--) {
    factorial *= i;
}
Console.WriteLine(factorial);
