DateTime d1 = DateTime.Now;
DateTime d2 = DateTime.UtcNow;
DateTime d3 = DateTime.Today;
int d4 = DateTime.Today.DayOfYear; // Changed type to int to match DayOfYear property
Console.WriteLine(d1);
Console.WriteLine(d2);
Console.WriteLine(d3);
Console.WriteLine(d4); // Added to use the variable and avoid IDE0059 warning
