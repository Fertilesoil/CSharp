namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float numero1, numero2, divisao;


            Console.WriteLine("Digite o primeiro número: ");
            numero1 = Convert.ToSingle(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite o primeiro número: ");
            numero2 = Convert.ToSingle(Console.ReadLine());
            Console.Clear();

            divisao = numero1 / numero2;

            Console.WriteLine($"A soma de {numero1} e {numero2} é: \n" + (numero1 + numero2));
            Console.WriteLine($"\nA subtração de {numero1} e {numero2} é: \n" + (numero1 - numero2));
            Console.WriteLine("\nA divisão de {0:F} e {1:F} é: {2:F}\n", numero1, numero2, divisao);
            Console.WriteLine($"\nA multiplicação de {numero1} e {numero2} é: \n" + (numero1 * numero2));
            Console.WriteLine($"\nRaiz quadrada de {numero1}\n: " + Math.Sqrt(numero1));
            Console.WriteLine($"\n{numero1} ^ { numero2}:"  + Math.Pow(numero1,numero2));
            Console.ReadKey();

        }
    }
}