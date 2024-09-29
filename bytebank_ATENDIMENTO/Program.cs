Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

//ARRAY SIMPLES
void TestaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;

    Console.WriteLine($"TAMANHO DO ARRAY {idades.Length}");
    int acumulador = 0;

    for (int i = 0; i < idades.Length; i++)
    {
        Console.WriteLine(idades[i]);
        acumulador += idades[i];
    }
    int media = acumulador / idades.Length;
    Console.WriteLine($"Média de idades = {media}");
}

//BUSCA NO ARRAY COM EQUALS
void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];
    for (int i = 0;i < arrayDePalavras.Length;i++)
    {
        Console.Write($"Digite a {i + 1} Palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.Write("Digite a palavra a ser buscada: ");
    string palavra = Console.ReadLine();

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        if (palavra.Equals(arrayDePalavras [i]))
        {
            Console.WriteLine($"Palavra encontrada: INDEX: {i+1}");
        }
    }
}



