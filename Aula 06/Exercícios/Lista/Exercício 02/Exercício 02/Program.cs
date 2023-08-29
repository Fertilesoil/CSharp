using System.ComponentModel;

namespace Exercício_02;

class Program
{
    static void Main(string[] args)
    {   
        int numero = 0;
        List<int> lista = new List<int>();

        lista.Add(2); lista.Add(5); lista.Add(1); lista.Add(3); lista.Add(4);
        lista.Add(9); lista.Add(7); lista.Add(8); lista.Add(10); lista.Add(6);
        
        Console.Write("Insira o número que você deseja encontrar: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if (lista.Count == numero)
        {
            Console.WriteLine($"O número {numero} está na posição: {lista.IndexOf(numero)}.");
        }

        else 
        {
            Console.WriteLine($"O número {numero} não foi encontrado!");
        }
    }
}
