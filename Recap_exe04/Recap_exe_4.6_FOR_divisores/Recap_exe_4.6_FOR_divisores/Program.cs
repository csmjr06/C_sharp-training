﻿using System;

Console.WriteLine("Entre com um inteiro: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++) {
    if (n%i == 0) {
        Console.WriteLine(i);
    }
}
