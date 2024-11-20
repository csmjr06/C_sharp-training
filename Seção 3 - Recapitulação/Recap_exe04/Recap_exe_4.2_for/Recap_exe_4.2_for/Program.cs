using System;

Console.WriteLine("Exercício - Imprimir ímpares");
int n = 0;
int x = 0;
int I = 0;
int O = 0;
Console.Write("Entre um valor inteiro: ");
n = int.Parse(Console.ReadLine());


for (int i = 1; i <= n; i++) {
    Console.Write("Entre um valor inteiro: ");
    x = int.Parse(Console.ReadLine());
    if (x >= 10 && x <= 20) {
        I++;
    } else {
        O++;
    }
}
Console.WriteLine(I + " in");
Console.WriteLine(O + " out");