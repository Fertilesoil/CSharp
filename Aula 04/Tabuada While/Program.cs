namespace Tabuada_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, contador = 1;

            Console.WriteLine("Qual tabuada você gostaria de visualizar?");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            while (contador <= 10)
            {
                Console.WriteLine($"{numero} x {contador} = {numero * contador}");
                contador++;
            }
        }
    }
}