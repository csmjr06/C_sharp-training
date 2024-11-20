// See https://aka.ms/new-console-template for more information

int x = 0;

while (x<1 || x>1000) {
    Console.WriteLine("Entre um valor inteiro:");
    x = int.Parse(Console.ReadLine());
}
for (int i = 1; i <= x; i++) {
    if (i%2 != 0) {
        Console.WriteLine(i);
    }
}

