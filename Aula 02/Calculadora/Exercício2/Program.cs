namespace Exercício2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, media;

            Console.WriteLine("Digite a primeira nota: ");
            n1 = Convert.ToSingle(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite a segunda nota: ");
            n2 = Convert.ToSingle(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite a terceira nota: ");
            n3 = Convert.ToSingle(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite a quarta nota: ");
            n4 = Convert.ToSingle(Console.ReadLine());
            Console.Clear();

            media = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine($"sua média é: {media:F1}");

        }
    }
}