namespace Exercício_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, res;
            int opcao;

            Console.WriteLine("Insira um número: ");
            n1 = Convert.ToSingle(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Insira mais um: ");
            n2 = Convert.ToSingle(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Escolha a operação desejada");
            Console.WriteLine("[1] | Soma          |");
            Console.WriteLine("[2] | Subtração     |");
            Console.WriteLine("[3] | Multiplicação |");
            Console.WriteLine("[4] | Divisão       |");
            opcao = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (opcao == 4 && n2 == 0)
            {
                Console.WriteLine("Não fazemos milagre amigue.");
                goto fim;
            }
                

            switch (opcao)
            {
                case 1:
                    res = n1 + n2;
                    Console.WriteLine($"A soma de {n1} e {n2} resulta em: {res}");
                    break;

                case 2:
                    res = n1 - n2;
                    Console.WriteLine($"A subração de {n1} e {n2} resulta em: {res}");
                    break;

                case 3:
                    res = n1 * n2;
                    Console.WriteLine($"A multiplicação de {n1} e {n2} resulta em: {res}");
                    break;

                case 4:
                    res = n1 / n2;
                    Console.WriteLine($"A divisão de {n1} e {n2} resulta em: {res}");
                    break;

                default:
                        Console.WriteLine("Operação inválida.");
                    break;
            }

            fim:
            Console.WriteLine("Obrigade por usar o programa =)");
        }
    }
}