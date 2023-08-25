namespace Pesquisa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome, continua = "S";
            int idade, esporte, futebol = 0, voleibolM18 = 0, basquetebolM18 = 0;

            do
            {
                
                Console.WriteLine("Digite seu nome: ");
                nome = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Qual sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                do
                {
                    Console.WriteLine("Digite seu esporte favorito");
                    Console.WriteLine("1 - Futebol");
                    Console.WriteLine("2 - Vôlei");
                    Console.WriteLine("3 - Basquete");
                    Console.WriteLine("4 - Outro");
                    esporte = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                } while (esporte < 1 || esporte > 4);

                if (esporte == 1)
                    futebol++;

                if (esporte == 2 && idade > 18)
                    voleibolM18++;

                if (esporte == 3 && idade < 18)
                    basquetebolM18++;

                Console.WriteLine("Deseja continuar? [S]   [N]");
                continua = Console.ReadLine().ToUpper();
                Console.Clear();

            } while (continua.Equals("S"));

            Console.WriteLine($"Total de pessoas que gostam de futebol: {futebol}");
            Console.WriteLine($"Total de pessoas que gostam de voleibol maiores de 18: {voleibolM18}");
            Console.WriteLine($"Total de pessoas que gostam de basquetebol menores de 18: {basquetebolM18}");
            Console.ReadKey();

        }
    }
}