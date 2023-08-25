namespace Exercício_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, par = 0, impar = 0;



            for (int contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine("Digite os números: ");
                numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                par++;
            }

            else
            {
                impar++;
            }

            }

            Console.Clear();
            Console.WriteLine($"Total de números pares: {par}");
            Console.WriteLine($"Total de números impares: {impar}");
        }
    }
}