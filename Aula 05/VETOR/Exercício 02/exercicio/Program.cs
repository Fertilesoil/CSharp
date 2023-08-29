namespace exercicio;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = new int [10]; 
        int soma = 0;
        float media = 0;
        string? vetorCompleto = "", indicesPares = "", indicesImpares = "";

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Digite 10 números por gentileza: ");
        vetor[i] = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        soma += vetor[i];
        media = soma / 10.0F;
        vetorCompleto += vetor[i] + " ";

      if (vetor[i] % 2 == 0)
      {
        indicesPares += vetor[i] + " ";
      }
        
    }

    for (int impar = 1; impar < 10; impar+=2)
    {
        indicesImpares += vetor[impar] + " ";
    }

        Console.WriteLine($"{vetorCompleto}");
        Console.WriteLine($"Números pares: {indicesPares}");
        Console.WriteLine($"Índices ímpares: {indicesImpares}");
        Console.WriteLine($"A soma do vetor é igual à: {soma}");
        Console.WriteLine($"A média dos números é: {media:F2}");
    }
}
