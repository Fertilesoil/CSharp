using System.ComponentModel.Design;

namespace Exercício_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 0, identidade, pessoadev = 0, backEnd = 0, cisTransFrontM = 0, cisTransMobileH = 0,
                naoBinarieFull = 0;
            float  total = 1, media = 0;
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
                Console.Clear();


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
                Console.Clear();

                if (pessoadev < 1 || pessoadev > 4)
                {
                    break;
                }


                Console.WriteLine("Certo, quer fazer mais uma pesquisa?");
                Console.WriteLine("[S]           [N]");
                sn = Console.ReadLine().ToLower();
                Console.Clear();

                if (sn.Equals("n"))
                {
                    break;
                }

                else
                {
                    total++;
                }

            if (pessoadev == 1)
            {
                backEnd++;
            }

            if (identidade == 1 && identidade == 4 && pessoadev == 2)
            {
                cisTransFrontM++;
            }

            if (identidade == 2 && identidade == 5 && pessoadev == 3 && idade > 40)
            {
                cisTransMobileH++;
            }

            if (identidade == 3 && pessoadev == 4 && idade < 30)
            {
                naoBinarieFull++; 
            }

            media = (idade * total) / total;

            }
            while (true);



            Console.WriteLine($"Pessoas desenvolvedoras Back End:                       {backEnd}");
            Console.WriteLine($"Mulheres Cis e Trans do FrontEnd:                {cisTransFrontM}");
            Console.WriteLine($"Homes Cis e Trans do Mobile maiores de 40 anos: {cisTransMobileH}");
            Console.WriteLine($"Pessoas Não Binaries FullStack menores de 30:    {naoBinarieFull}");
            Console.WriteLine($"Total de pessoas que responderam a pesquisa:              {total}");
            Console.WriteLine($"Média de idade das pessoas que responderam à pesquisa:    {media}");
        }
    }
}