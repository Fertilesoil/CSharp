namespace Exercício3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salarioBruto, adicionalNoturno, horasExtras, desconto, sl;

            Console.WriteLine("Insira salário bruto: ");
            salarioBruto = Convert.ToSingle(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Insira adicional noturno: ");
            adicionalNoturno = Convert.ToSingle(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Insira horas extras: ");
            horasExtras = Convert.ToSingle(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Insira Descontos: ");
            desconto = Convert.ToSingle(Console.ReadLine());
            Console.Clear();

            sl = salarioBruto + adicionalNoturno + (horasExtras * 5) - desconto;

            Console.WriteLine($"Salário líquido: {sl:F}");

        }
    }
}