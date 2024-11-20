using System;

int X, Y;

Console.WriteLine("Exercício - Ler coordenadas");
Console.Write("Entre com as coordenadas x e y: ");
Console.Write("Entre com as coordenadas x e y: ");
string[] C = Console.ReadLine().Split(' ');
X = int.Parse(C[0]);
Y = int.Parse(C[1]);

while (X != 0 && Y != 0) {
    if (X > 0 && Y > 0) {
        Console.Write("Primeiro quadrante");
    }
    else if (X < 0 && Y > 0) {
        Console.Write("Segundo quadrante");
    }
    else if (X < 0 && Y < 0) {
        Console.Write("Terceiro quadrante");
    }
    else {
        Console.Write("Quarto quadrante");
    }
    Console.WriteLine();
    Console.Write("Entre com as coordenadas x e y: ");
    string[] c = Console.ReadLine().Split(' ');
    X = int.Parse(c[0]);
    Y = int.Parse(c[1]);
}