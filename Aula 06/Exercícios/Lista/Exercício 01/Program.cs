using System.ComponentModel;

namespace Exercício_01;

class Program
{
    static void Main(string[] args)
    {
        List<string> cores = new List<string>();

        while (cores.Count < 5)
        {
            Console.Write("Digite a cor: ");
            string cor = Console.ReadLine()!;
            cores.Add(cor);
            Console.Clear();
        }

        Console.WriteLine();
        
        foreach (var lista in cores)
        {
            Console.WriteLine(lista);
        }

        Console.WriteLine();

        cores.Sort();
        foreach (var lista in cores)
        {
            Console.WriteLine(lista);
        }
    }
}
