int qtdHomem = 0;
int qtdMulher = 0;
Console.WriteLine($"Quantas pessoas tem na sua mesa?");
int qtdDeEntrevistados = int.Parse(Console.ReadLine()!);
int qtdDePessoas = 0;
int naoGosta = 0;

for (int i = 1; i <= qtdDeEntrevistados; i++)
{
    Console.WriteLine($"Qual é o seu sexo? m/f");
    string sexo = Console.ReadLine();

    if (sexo == "f")
    {
        qtdMulher++;
    }
    else
    {
        qtdHomem++;
    }
    
    Console.WriteLine($"Você gosta de esporte? s/n");
    string gostaDeEsporte = Console.ReadLine();  
    
    if (gostaDeEsporte == "s")
    {
        qtdDePessoas++;
    }
    else
    {
        naoGosta++;
    }
}

float percentual = (100 / qtdDeEntrevistados) * qtdDePessoas;
float percentualDoNao = (100 / qtdDeEntrevistados) * naoGosta;



Console.WriteLine($"Resultados Finais! 😁");

Console.WriteLine($"Quantidade de mulheres: {qtdMulher}");
Console.WriteLine($"Quantidade de homens: {qtdHomem}");
Console.WriteLine($"Quantidade total de pessoas: {qtdDeEntrevistados}");
Console.WriteLine($"Quantidade de pessoas que gostam de esportes: {qtdDePessoas}");
Console.WriteLine($"Quantidade de pessoas que não gostam de esportes: {naoGosta}");
Console.WriteLine($"Percentual de pessoas que gostam de esportes: {percentual}%");
Console.WriteLine($"Percentual de pessoas que não gostam de esportes: {percentualDoNao}%");


