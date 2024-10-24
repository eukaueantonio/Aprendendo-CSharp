Console.WriteLine(@"
+---------------------------------------+
|               Bem vindo               |
|                  ao                   |
|          programa banco XPTO          |
+---------------------------------------+
");

Console.WriteLine($"Digite seu salario: ");
float salario = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite seu gasto: ");
float gasto = float.Parse(Console.ReadLine()!);


if (gasto >= salario )
{
    Console.WriteLine($"Orçamento estourado");
}
else
{
    Console.WriteLine($"Gastos dentro do orçamento");
}