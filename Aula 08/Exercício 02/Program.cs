using Exercício_02;
using Exercício_02.Funcionário;

namespace Exercício_02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Funcionario primeiro = new (35, "Roberto Manfredini", 3500.00F, "Full Stack JR", 1, 7);
            Funcionario segundo = new (28, "Voltino Valério", 5000.00F, "Full Stack JR.2", 3, 0);


            primeiro.Visualizar();
            Console.WriteLine();
            segundo.Visualizar();
        }
    }
}