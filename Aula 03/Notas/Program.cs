namespace Notas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, media;

            Console.Write("Digite a primeira nota: ");
            n1 = Convert.ToSingle(Console.ReadLine());
            Console.Clear();

            Console.Write("Digite a primeira nota: ");
            n2 = Convert.ToSingle(Console.ReadLine());
            Console.Clear();

            media = (n1 + n2) / 2;

            Console.Write((media >= 6) ? "Aprovade !!" : "Poxa amigue, não foi dessa vez.");
        }
    }
}