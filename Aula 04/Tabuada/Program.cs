namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Qual tabuada você gostaria de visualizar?");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            for (int contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine($"{numero} x {contador} = {numero * contador}");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine($"{numero} + {contador} = {numero + contador}");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine($"{numero} / {contador} = {numero / contador}");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine($"{numero} - {contador} = {numero - contador}");
            }


        }
    }
}