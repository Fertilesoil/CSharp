using System.Runtime.Serialization;

namespace Exercício_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, soma; 

            Console.Write("Digite o número A: ");
            a = Convert.ToInt32(Console.ReadLine());   
            Console.Clear();

            Console.Write("Digite o número B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.Write("Digite o número C: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            soma = a + b;

            if (soma > c)
            {
                Console.WriteLine($"A soma de {a} e {b} é Maior que {c}.");
            }

            else if (soma < c)
            {
                Console.WriteLine($"A soma de {a} e {b} é Menor que {c}.");
            }

            else if (soma == c)
            {
                Console.WriteLine($"A soma de {a} e {b} é igual á {c}.");
            }

            Console.WriteLine("Obrigado por usar o programa =)");
            Console.ReadKey();
;
        }
    }
}