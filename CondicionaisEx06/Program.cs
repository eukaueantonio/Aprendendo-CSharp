Console.WriteLine(@"
+---------------------------------+
|    Bem vindo ao programa de     |
|           frequência            |
+---------------------------------+ 
");

Console.WriteLine("Olá");

Console.WriteLine($"Informe sua porcentagem de frequência: ");
float frequencia = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe sua nota: ");
float nota = float.Parse(Console.ReadLine());


if (frequencia >= 75 && nota >= 7 ) {
    Console.WriteLine($"Aprovado");
} else if (nota >3 && nota <7 ) {
    Console.WriteLine($"Recuperação");
} else {
    Console.WriteLine($"Reprovado");
}

