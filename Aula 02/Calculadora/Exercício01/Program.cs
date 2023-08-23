namespace Exercício01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario, abono, novoSalario;
            
            Console.WriteLine("Digite o salário: ");
            salario=Convert.ToSingle(Console.ReadLine());
            Console.Clear();
            
            Console.WriteLine("Digite o abono: ");
            abono=Convert.ToSingle(Console.ReadLine());
            Console.Clear();

            novoSalario = salario + abono;

            Console.WriteLine($"Seu novo salário é :{novoSalario:F} ");
        }
    }
}