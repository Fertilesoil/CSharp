namespace Exercício_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float saldo = 1000.00F, saque, deposito;
            char volta;
            int opcao;

            inicio:

            Console.WriteLine("Escolha a operação desejada:");
            Console.WriteLine("============================");
            Console.WriteLine("[1] -                  Saldo");
            Console.WriteLine("[2] -                  Saque");
            Console.WriteLine("[3] -               Depósito");
            Console.WriteLine("============================");
            opcao = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (opcao)
            {
                case 1:
                    Console.WriteLine($"Seu saldo é: {saldo:c}");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 2:
                    Console.WriteLine("Qual o valor que deseja sacar?");
                    saque = Convert.ToSingle(Console.ReadLine());
                    Console.Clear();

                    if (saque <= saldo)
                    {
                        saldo -= saque;
                        Console.WriteLine("Operação Realizada com sucesso !");
                        Console.WriteLine("================================");
                        Console.WriteLine($"Seu novo saldo é:     {saldo:c}");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    else
                    {
                        Console.WriteLine("Sentimos muito amigue, saldo insuficiente.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    break;

                case 3:
                    Console.WriteLine("Qual o valor que deseja depositar?");
                    deposito = Convert.ToSingle(Console.ReadLine());
                    Console.Clear();

                    saldo += deposito;

                    Console.WriteLine("Operação Realizada com sucesso !");
                    Console.WriteLine("================================");
                    Console.WriteLine($"Seu novo saldo é:    {saldo:c}");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                default:
                    Console.WriteLine("Operação inválida !");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }

            Console.WriteLine("Gostaria de realizar outra operação?");
            Console.WriteLine("[S]             ||               [N]");
            volta = Char.Parse(Console.ReadLine().ToLower());
            Console.Clear();

            if (volta == 's')
            {
                goto inicio;
            }

            else
            {
                Console.WriteLine("Obrigade por usar o programa.");    
            }
        }
    }
}