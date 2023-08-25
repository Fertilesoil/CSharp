using System.Runtime.Serialization;

namespace Exercício_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entrada = 1, soma = 0;

            do
            {
                Console.WriteLine("Digite seus numeros amigue: ");
                entrada = Convert.ToInt32(Console.ReadLine());

                if (entrada > 0)
                {
                    soma += entrada;
                }
            }
            while (entrada != 0);

            Console.WriteLine($"A soma dos números positivos é: {soma}");

        }
    }
}