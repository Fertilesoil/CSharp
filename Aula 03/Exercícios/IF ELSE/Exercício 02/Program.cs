namespace Exercício_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero;
            string pi, np;

            Console.WriteLine("Me diz seu número: ");
            numero = Convert.ToSingle(Console.ReadLine());
            Console.Clear();
            
            if (numero % 2 == 0)
            {
                pi = "par";
            }
            
            else 
            {
                pi = "ímpar";
            }

            if (numero >= 0)
            {
                np = "positivo";
            }

            else
            {
                np = "negativo";
            }

            Console.WriteLine($"O número {numero} é {pi} e {np}! \n\n");
            Console.WriteLine("Obrigade por usar o programa =)");
            Console.ReadKey();
        }
    }
}