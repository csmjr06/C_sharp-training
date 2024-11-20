using System;

Console.WriteLine("Exercício - Imprimir ímpares");
int X = 0;
while (X < 1 || X > 1000) {
    Console.Write("Entre um valor inteiro: ");
    X = int.Parse(Console.ReadLine());
}

for (int i = 1; i <= X; i++) {
    if (i % 2 != 0) {
        Console.WriteLine(i);
    }
}
Console.WriteLine("FIM");