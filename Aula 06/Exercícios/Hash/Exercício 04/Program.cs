namespace Exercício_04;

class Program
{
    static void Main(string[] args)
    {
        int numero = 0;
        HashSet<int> talvezLista = new HashSet<int>();

        talvezLista.Add(2); talvezLista.Add(5); talvezLista.Add(1); talvezLista.Add(3); talvezLista.Add(4);
        talvezLista.Add(9); talvezLista.Add(7); talvezLista.Add(8); talvezLista.Add(10); talvezLista.Add(6);

        Console.Write("Insira o número que você deseja encontrar: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if (talvezLista.Contains(numero))
        {
            Console.WriteLine($"O número {numero} foi encontrado!");
        }
        else
        {
            Console.WriteLine($"O número {numero} não foi encontrado.");
        }
    }
}
