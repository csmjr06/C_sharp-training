using System;
using System.Globalization;

Console.WriteLine("Exercício 01 - Ver se no. é negativo");

int Z1;
Console.Write("Entre o número inteiro: ");
Z1 = int.Parse(Console.ReadLine());
if (Z1 < 0) {
    Console.WriteLine("NEGATIVO");
}
else {
    Console.WriteLine("NÃO NEGATIVO");
}
Console.WriteLine();

Console.WriteLine("Exercício 02 - Ver se é par ou ímpar");

int Z2;
Console.Write("Entre o número inteiro: ");
Z2 = int.Parse(Console.ReadLine());
if (Z2 % 2 == 0) {
    Console.WriteLine("PAR");
}
else {
    Console.WriteLine("ÍMPAR");
}
Console.WriteLine();

Console.WriteLine("Exercício 03 - Ver se são múltiplos");

int A, B;
Console.Write("Entre os números inteiros A B: ");
string[] lista = Console.ReadLine().Split(" ");
A = int.Parse(lista[0]);
B = int.Parse(lista[1]);
if (B % A == 0 || A % B == 0) {
    Console.WriteLine("São Múltiplos");
}
else {
    Console.WriteLine("Não são Múltiplos");
}

Console.WriteLine();

Console.WriteLine("Exercício 04 - Duração do jogo");

int Hi, Hf, Duracao;
Console.Write("Entre a hora inicial e final do jogo: ");
string[] horas = Console.ReadLine().Split(" ");
Hi = int.Parse(horas[0]);
Hf = int.Parse(horas[1]);
if (Hf > Hi) {
    Duracao = Hf - Hi;
    Console.WriteLine("O JOGO DUROU " + Duracao + " HORA(S).");
}
else {
    Duracao = (Hf + 24) - Hi;
    Console.WriteLine("O JOGO DUROU " + Duracao + " HORA(S).");
}

Console.WriteLine();

Console.WriteLine("Exercício 05 - Preço do Item");

int item, quant;
double total;
Console.Write("Entre um item e a quantidade: ");
string[] itens = Console.ReadLine().Split(" ");
item = int.Parse(itens[0]);
quant = int.Parse(itens[1]);

switch (item) {
    case 1:
        total = quant * 4.00;
        Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        break;
    case 2:
        total = quant * 4.50;
        Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        break;
    case 3:
        total = quant * 5.00;
        Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        break;
    case 4:
        total = quant * 2.00;
        Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        break;
    case 5:
        total = quant * 1.50;
        Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        break;
    default:
        total = quant * 4.0;
        Console.WriteLine("Item não encontrado" + total.ToString("F2", CultureInfo.InvariantCulture));
        break;
}

Console.WriteLine();

Console.WriteLine("Exercício 06 - Intervalos");

int item, quant;
double valor6;
Console.Write("Entre valor: ");
valor6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if (0 <= valor6 && valor6 <= 25) {
    Console.WriteLine("Intervalo [0,25]");
}
else if (25 < valor6 && valor6 <= 50) {
    Console.WriteLine("Intervalo (25,50]");
}
else if (50 < valor6 && valor6 <= 75) {
    Console.WriteLine("Intervalo (50,75]");
}
else if (75 < valor6 && valor6 <= 100) {
    Console.WriteLine("Intervalo (75,100]");
}
else if (valor6 < 0 || valor6 > 100) {
    Console.WriteLine("Fora de Intervalo");
}

Console.WriteLine();

Console.WriteLine("Exercício 07 - Qual quadrante");

double x, y;

Console.Write("Entre x e y: ");
string[] coord = Console.ReadLine().Split(" ");
x = double.Parse(coord[0], CultureInfo.InvariantCulture);
y = double.Parse(coord[1], CultureInfo.InvariantCulture);

if (x == 0 && y == 0) {
    Console.WriteLine("Origem");
}
else if (x == 0 && y != 0) {
    Console.WriteLine("Eixo Y");
}
else if (x != 0 && y == 0) {
    Console.WriteLine("Eixo X");
}
else if (x > 0 && y > 0) {
    Console.WriteLine("Q1");
}
else if (x < 0 && y > 0) {
    Console.WriteLine("Q2");
}
else if (x < 0 && y < 0) {
    Console.WriteLine("Q3");
}
else if (x > 0 && y < 0) {
    Console.WriteLine("Q4");
}

Console.WriteLine();

Console.WriteLine("Exercício 08 - Salário e IR");

double salario, imposto;

Console.Write("Entre o salário: R$ ");
salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if (salario <= 2000.00) {
    imposto = 0.00;
}
else if (salario > 2000.00 && salario <= 3000.00) {
    imposto = .08 * (salario - 2000.00);
}
else if (salario > 3000.00 && salario <= 4500.00) {
    imposto = .18 * (salario - 3000) + (1000.00 * .08);
}
else {
    imposto = .28 * (salario - 4500.00) + (1500.00 * .18) + (1000.00 * .08);
}

if (imposto == 0.00) {
    Console.WriteLine("Isento");
}
else {
    Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
}

Console.WriteLine();