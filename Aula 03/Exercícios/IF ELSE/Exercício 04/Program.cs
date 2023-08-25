namespace Exercício_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string? tipo, familia, comida; 

            Console.WriteLine("Vertebrado ou Invertebrado: ");
            tipo = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Qual animal ele é: ");
            familia = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Qual sua alimentação: ");
            comida = Console.ReadLine();
            Console.Clear();

            if (tipo is not null && familia is not null && comida is not null)
            if (tipo.Equals("Vertebrado") && familia.Equals("Ave") && comida.Equals("Carnívoro"))
            {
                Console.WriteLine("Seu animal é uma águia!");
                Console.ReadKey();  
            }

            if (tipo is not null && familia is not null && comida is not null)
                if (tipo.Equals("Vertebrado") && familia.Equals("Ave") && comida.Equals("Onívoro"))
            {
                Console.WriteLine("Seu animal é uma pomba!");
                Console.ReadKey();
            }

            if (tipo is not null && familia is not null && comida is not null)
                if (tipo.Equals("Vertebrado") && familia.Equals("Mamífero") && comida.Equals("Onívoro"))
            {
                Console.WriteLine("Seu animal é o homem!");
                Console.ReadKey();
            }

            if (tipo is not null && familia is not null && comida is not null)
                if (tipo.Equals("Vertebrado") && familia.Equals("Mamífero") && comida.Equals("Herbívoro"))
            {
                Console.WriteLine("Seu animal é uma vaca!");
                Console.ReadKey();
            }

            if (tipo is not null && familia is not null && comida is not null)
                if (tipo.Equals("Invertebrado") && familia.Equals("Inseto") && comida.Equals("Hematófago"))
            {
                Console.WriteLine("Seu animal é uma pulga!");
                Console.ReadKey();
            }

            if (tipo is not null && familia is not null && comida is not null)
                if (tipo.Equals("Invertebrado") && familia.Equals("Inseto") && comida.Equals("Herbívoro"))
            {
                Console.WriteLine("Seu animal é uma lagarta!");
                Console.ReadKey();
            }

            if (tipo is not null && familia is not null && comida is not null)
                if (tipo.Equals("Invertebrado") && familia.Equals("Anelídeo") && comida.Equals("Hematófago"))
            {
                Console.WriteLine("Seu animal é um sanguessuga!");
                Console.ReadKey();
            }

            if (tipo is not null && familia is not null && comida is not null)
                if (tipo.Equals("Invertebrado") && familia.Equals("Anelídeo") && comida.Equals("Onívoro"))
            {
                Console.WriteLine("Seu animal é uma minhoca!");
                Console.ReadKey();
            }

            Console.WriteLine("Obrigado por usar o programa =)");
            Console.ReadKey();
        }
    }
}