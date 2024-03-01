int[] decad = new int[5];
int[] nagui = new int[5];
int escolha =  0;
string? opgg;

//Declarar os vetores
for(int i=0; i<5; i++)
{
    Console.WriteLine((i+1) + "º número do primeiro vetor: ");
    opgg = Console.ReadLine();
    Int32.TryParse(opgg, out decad[i]);
    Console.WriteLine((i + 1) + "º número do segundo vetor: ");
    opgg = Console.ReadLine();
    Int32.TryParse(opgg, out nagui[i]);
}

//menu
int menu()
{
    string? i;
    Console.WriteLine();
    Console.WriteLine("======Menu======");
    Console.WriteLine();
    Console.WriteLine("1- A soma dos elementos de cada vetor");
    Console.WriteLine("2- A diferença dos elementos de cada vetor");
    Console.WriteLine("3- O produto dos elementos de cada vetor, nas respectivas posições");
    Console.WriteLine("4- A divisão entre os elementos de cada vetor, nas respectivas posições");
    Console.WriteLine("Opção: ");

    i = Console.ReadLine();
    Int32.TryParse(i, out escolha);

    return escolha;
}
menu();
if(escolha == 1)
{
    for(int j=0; j<5; j++)
    {
        Console.WriteLine("Resultado: "+ (decad[j] + nagui[j]));
    }
}
else if (escolha == 2)
{
    for (int j = 0; j < 5; j++)
    {
        Console.WriteLine("Resultado: " + (decad[j] - nagui[j]));
    }
}
else if (escolha == 3)
{
    for (int j = 0; j < 5; j++)
    {
        Console.WriteLine("Resultado: " + (decad[j] * nagui[j]));
    }
}
else if (escolha == 4)
{
    for (int j = 0; j < 5; j++)
    {
        Console.WriteLine("Resultado: " + (decad[j] / nagui[j]));
    }
}

// Demacliaaa! - gnar