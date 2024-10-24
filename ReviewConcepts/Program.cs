//criar um cabeçalho de boas vindas 
Console.WriteLine(@"
+--------------------------------------------+
|                Bem vindo!!!                |
+--------------------------------------------+
");
Console.WriteLine(); //linha vazia

//pedir os dados de cadastro
Console.WriteLine($"Olá, digite seu nome: ");
string nome = Console.ReadLine();

//sobrenome
Console.WriteLine($"Olá {nome}, digite seu sobrenome: ");
string sobrenome = Console.ReadLine(); 

//data de nascimento
Console.WriteLine($"{nome}, digite sua data de nascimento: ");
string DtNascimento = Console.ReadLine();

//email 
Console.WriteLine($"{nome}, digite seu email: ");
string email = Console.ReadLine();

//telefone
Console.WriteLine($"{nome}, digite seu telefone: ");
UInt128 telefone = UInt128.Parse(Console.ReadLine()!);

//cpf
Console.WriteLine($"{nome}, digite seu cpf: ");
UInt128 cpf = UInt128.Parse(Console.ReadLine()!);

//endereço
Console.WriteLine($"{nome}, digite seu endereço: ");
string endereco = Console.ReadLine();

//estado civíl 
Console.WriteLine($"{nome}, digite seu estado civíl: ");
string estadoCivil = Console.ReadLine();

//idade 
Console.WriteLine($"{nome}, digite o ano que você nasceu: ");
int anoNascimento = int.Parse(Console.ReadLine()!);
int anoAtual = DateTime.Now.Year;
int idade = anoAtual - anoNascimento;


// mostrar esses dados cadastrados
Console.WriteLine($"{nome}, seus dados foram cadastrados com sucesso!");
Console.WriteLine($"Nome completo: {nome} {sobrenome}");
Console.WriteLine($"Data de nascimento: {DtNascimento}");
Console.WriteLine($"Email: {email}");
Console.WriteLine($"Telefone: {telefone}");
Console.WriteLine($"CPF: {cpf}");
Console.WriteLine($"Endereço: {endereco}");
Console.WriteLine($"Estado civíl: {estadoCivil}");
Console.WriteLine($"Idade: {idade}");



//Estruturas condicionais
//Laços de repetições
//Arrays

