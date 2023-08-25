using System.ComponentModel.Design;

namespace Exercício_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 0, identidade, pessoadev;
            string? sn;


            do
            {

                Console.WriteLine("Qual sua idade?");
                idade = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("1 – Mulher Cis");
                Console.WriteLine("2 - Homem Cis");
                Console.WriteLine("3 - Não Binarie");
                Console.WriteLine("4 - Mulher Trans");
                Console.WriteLine("5 - Homem Trans");
                Console.WriteLine("6 - Outros");
                identidade = Convert.ToInt32(Console.ReadLine());
                

                if (identidade < 1 || identidade > 6)
                {
                    break;
                }

                Console.WriteLine("Pessoa Desenvolvedora");
                Console.WriteLine("1 - Back End");
                Console.WriteLine("2 - Front End");
                Console.WriteLine("3 - Mobile");
                Console.WriteLine("4 - FullStack");
                pessoadev = Convert.ToInt32(Console.ReadLine());
                

                if (identidade < 1 || identidade > 4)
                {
                    break;
                }

                Console.WriteLine("Certo, quer fazer mais uma pesquisa?");
                Console.WriteLine("[S]           [N]");
                sn = Console.ReadLine().ToLower();

                if (sn.Equals("n"))
                {
                    break;
                }

            }
            while (true);


        }
    }
}