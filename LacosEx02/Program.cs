for (int n = 1; n <=10; n++)
{
    Console.WriteLine($"Qual seu sexo? m/f");
    string sexo = Console.ReadLine()!;

    Console.WriteLine($"Você gostou do produto? s/n");
    string resposta = Console.ReadLine()!;

    if(sexo == "m")
    {
        homem ++;
    }
    else 
    {
        mulher ++;
    }

    if(sexo == "f" && resposta == "s")
    {
        mulhersim ++;
    }
    if(sexo == "m" && resposta == "n")
    {
        homemnao ++;
    }

    if (resposta == "s")
    {
        respostasim ++;
    }
    else{
        respostanao ++;
    }
}
float percentual = (100 * homemnao) / homem;

Console.WriteLine($"Total de pessoas que dizeram 'sim' é {respostasim}");
Console.WriteLine($"Total de pessoas que dizeram 'não' é {respostanao}");
Console.WriteLine($"Total de mulheres que dizeram 'sim' é {mulhersim}");
Console.WriteLine($"Percentual de homens que dizeram 'não' é {percentual}%");

