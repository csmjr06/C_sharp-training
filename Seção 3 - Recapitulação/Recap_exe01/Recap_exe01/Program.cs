using System;
using System.Globalization;

int A, B, soma;

Console.WriteLine("Exercício 01 - Soma de Valores");

A = int.Parse(s: Console.ReadLine());
B = int.Parse(s: Console.ReadLine());

soma = A + B;

Console.WriteLine("SOMA = " + soma);

Console.WriteLine("Exercício 02 - Área do Círculo");

double R, Pi, Area;
Console.Write("Entre com o raio do círculo: ");
R = double.Parse(s: Console.ReadLine(), CultureInfo.InvariantCulture);
Pi = Math.PI;
Area = Math.Pow(R, 2) * Pi;
Console.WriteLine("Área = " + Area.ToString("F4",CultureInfo.InvariantCulture));
Console.WriteLine();

Console.WriteLine("Exercício 03 - Diferença de Produto");

int A3, B3, C3, D3, Dif;

Console.WriteLine();

Console.WriteLine(" Entre com os Valores inteiros de A, B, C e D: ");
Console.Write("A: ");
A3 = int.Parse(s: Console.ReadLine());
Console.Write("B: ");
B3 = int.Parse(s: Console.ReadLine());
Console.Write("C: ");
C3 = int.Parse(s: Console.ReadLine());
Console.Write("D: ");
D3 = int.Parse(s: Console.ReadLine());

Dif = (A3 * B3 - (C3 * D3));
Console.WriteLine("DIFERENÇA = (A * B - C * D) = " + Dif);

Console.WriteLine();

Console.WriteLine("Exercício 04 - Dados do Funcionário");

int num, hrs;
double vph, salary;

Console.WriteLine();

Console.Write("Número do funcionário: ");
num = int.Parse(s: Console.ReadLine());
Console.Write("Horas trabalhadas: ");
hrs = int.Parse(s: Console.ReadLine());
Console.Write("Valor por hora: ");
vph = double.Parse(s: Console.ReadLine(), CultureInfo.InvariantCulture);

salary = (hrs * vph);
Console.WriteLine("NUMBER = " + num);
Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine();


Console.WriteLine("Exercício 05 - Código de peça");

int cod1, cod2, nrp1, nrp2;
double vpp1, vpp2, valor1, valor2, total;

Console.WriteLine();

Console.WriteLine("Entre com codigo da peça 1, número de peças 1 e o valor unitário de cada peça: ");
string[] lista1 = Console.ReadLine().Split(' ');
cod1 = int.Parse(lista1[0]);
nrp1 = int.Parse(lista1[1]);
vpp1 = double.Parse(lista1[2], CultureInfo.InvariantCulture);
valor1 = nrp1 * vpp1;

Console.WriteLine("Entre com codigo da peça 2, número de peças 2 e o valor unitário de cada peça: ");
string[] lista2 = Console.ReadLine().Split(' ');
cod2 = int.Parse(lista2[0]);
nrp2 = int.Parse(lista2[1]);
vpp2 = double.Parse(lista2[2], CultureInfo.InvariantCulture);
valor2 = nrp2 * vpp2;

total = valor1 + valor2;

Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));


Console.WriteLine("Exercício 06 - Ponto flutuante");

double pA, pB, pC;
double Atriangulo, Acirculo, Atrapezio, Aquadrado, Aretangulo;

Console.WriteLine();

Console.WriteLine("Entre com os três valores: ");
string[] lista = Console.ReadLine().Split(' ');
pA = double.Parse(lista[0], CultureInfo.InvariantCulture);
pB = double.Parse(lista[1], CultureInfo.InvariantCulture);
pC = double.Parse(lista[2], CultureInfo.InvariantCulture);
Atriangulo = pA * pC / 2;
Acirculo = Math.Pow(pC, 2) * Pi;
Atrapezio = (pA + pB) * pC / 2;
Aquadrado = Math.Pow(pB, 2);
Aretangulo = pA * pB;

Console.WriteLine("TRIANGULO: " + Atriangulo.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("CIRCULO: " + Acirculo.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("TRAPEZIO: " + Atrapezio.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("QUADRADO: " + Aquadrado.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("RETANGULO: " + Aretangulo.ToString("F3", CultureInfo.InvariantCulture));
