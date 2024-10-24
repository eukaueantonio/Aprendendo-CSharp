Console.WriteLine(@"
+------------------------------+
|   Bem vindo ao programa dos  |
|          triângulos          |
+------------------------------+
");

int ladoA = 30;
int ladoB = 40;
int ladoC = 40;

if (ladoA == ladoB && ladoB == ladoC)
{
    Console.WriteLine($"O triângulo eh equilátero");
}
else if (ladoA == ladoC || ladoB == ladoC || ladoC == ladoA)
{
    Console.WriteLine($"O triângulo eh  Isóscele");
}
else
{
    Console.WriteLine($"O triângulo eh escaleno");
}
Console.WriteLine();