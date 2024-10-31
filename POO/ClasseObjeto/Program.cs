// importando as classes de dentro da pasta Classe
using ClasseObjeto.Classe;

// cria o objeto/variavel animal
Animal cachorro = new Animal(); 

cachorro.nome = "Bella";
cachorro.raca = "Vira-lata";
cachorro.cor = "Preta e branca";
cachorro.idade = 6;

Console.WriteLine($"Nome da minha cachorrinha: {cachorro.nome}");
Console.WriteLine($"Raca da {cachorro.nome}: {cachorro.raca}");
Console.WriteLine($"Cor da {cachorro.nome}: {cachorro.cor}");
Console.WriteLine($"Idade da {cachorro.nome}: {cachorro.idade}");

Console.WriteLine($"");
Console.WriteLine($"");

Animal girafa = new Animal();

girafa.nome = "Melman";
girafa.raca = "Girafa";
girafa.cor = "Amarelo claro com marrom alaranjado";
girafa.idade = 11;

Console.WriteLine($"Nome da {girafa.raca}: {girafa.nome}");
Console.WriteLine($"Raca da {girafa.nome}: {girafa.raca}");
Console.WriteLine($"Cor da {cachorro.nome}: {girafa.cor}");
Console.WriteLine($"Idade da {girafa.nome}: {girafa.idade}");


