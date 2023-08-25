using System.Xml.Schema;

namespace Exercício_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, quantidade, total;

            Console.WriteLine("1 - Cachorro Quente | R$10,00");
            Console.WriteLine("2 - X-Salada        | R$15,00");
            Console.WriteLine("3 - X-Bacon         | R$18,00");
            Console.WriteLine("4 - Bauru           | R$12,00");
            Console.WriteLine("5 - Refrigerante    | R$8,00");
            Console.WriteLine("6 - Suco de Laranja | R$13,00");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.Write("Qual a quantidade que você deseja?");
            quantidade = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

           

            switch (numero)
            {
                case 1:
                    numero = 10;
                    total = quantidade * numero;
                    Console.WriteLine(); 
                    Console.WriteLine($"| Cachorro Quente \n Total: {total:c}");
                    Console.ReadKey();
                        break;
                case 2:
                    numero = 15;
                    total = quantidade * numero;
                    Console.WriteLine(); 
                    Console.WriteLine($"| X-Salada \n Total: {total:c}");
                    Console.ReadKey();
                        break;
                case 3:
                    numero = 18;
                    total = quantidade * numero;
                    Console.WriteLine(); 
                    Console.WriteLine($"| X-Bacon \n Total: {total:c}");
                    Console.ReadKey();
                        break;
                case 4:
                    numero = 12;
                    total = quantidade * numero;
                    Console.WriteLine(); 
                    Console.WriteLine($"| Bauru \n Total: {total:c}");
                    Console.ReadKey();
                        break;
                case 5:
                    numero = 5;
                    total = quantidade * numero;
                    Console.WriteLine(); 
                    Console.WriteLine($"| Refrigerante \n Total: {total:c}");
                    Console.ReadKey();
                        break;
                case 6:
                    numero = 13;
                    total = quantidade * numero;
                    Console.WriteLine("==========================="); 
                    Console.WriteLine($"    Suco de Laranja ");
                    Console.WriteLine("===========================");
                    Console.WriteLine($"Total:\t\t {total:c}");
                    Console.WriteLine("===========================");
                    Console.ReadKey();
                        break;
                default:
                    Console.WriteLine("Opção não existe.");
                    break;
            }

        }

    }
}