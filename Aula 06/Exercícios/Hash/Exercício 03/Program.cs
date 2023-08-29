namespace Exercício_03;

class Program
{
    static void Main(string[] args)
    {
        HashSet<int> numeros = new HashSet<int>();

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Digite um número: ");
            int recebidos = Convert.ToInt32(Console.ReadLine())!;
            numeros.Add(recebidos);
            Console.Clear();
        }

        foreach (var l in numeros)
        {
            Console.Write(l + " ");
        }
    }
}
