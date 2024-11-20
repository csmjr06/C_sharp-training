using System;
using System.Globalization;

Console.WriteLine();
int senha = 0;
Console.Write("Entre com a senha: ");
senha = int.Parse(Console.ReadLine());

while (senha != 2002) {
    Console.WriteLine("Senha Inválida");
    Console.Write("Entre com a senha: ");
    senha = int.Parse(Console.ReadLine());
}
Console.WriteLine("Acesso Permitido");


