Console.WriteLine(@"
+------------------------+
|   Bem ao programa de   |
|         senhas         |
+------------------------+
");

int senha = 1234;

Console.WriteLine("Digite sua senha: ");
int senhaUsuario = int.Parse(Console.ReadLine());

if (senhaUsuario == senha)
{
    Console.WriteLine($"ACESSO PERIMITIDO");
}
else
{
    Console.WriteLine($"ACESSO NEGADO");
}