namespace Exercício_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ?nome, sn;
            int idade;
            bool s = false;

            Console.WriteLine("Qual seu nome ?");
            nome = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Qual sua idade ?");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("É sua primeira doação ?");
            Console.WriteLine("[S] [N]");
            sn = Console.ReadLine().ToUpper();
            Console.Clear();

            if (sn.Equals("S"))
            { 
                s = true;
            }

            else if (sn.Equals("N"))
            {
                s = false;
            }

            if (idade >= 18 && idade <= 60)
            {
                Console.WriteLine($"{nome} pode doar !");
                Console.ReadKey();
                Console.Clear();
            }

            else if (idade > 60 && idade <= 69 && s == false)
            {
                Console.WriteLine($"{nome} não pode doar !");
                Console.ReadKey();
                Console.Clear();
            }

            else
            {
                Console.WriteLine("Não vai rolar doação amigue.");
                Console.ReadKey();
                Console.Clear();
            }

            
        }
    }
}