namespace Exercício_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ?nome;
            int codigo;
            float salario, reajuste;

            Console.WriteLine("Digite o número do seu cargo: ");
            Console.WriteLine("[1] | Gerente        | 10%");
            Console.WriteLine("[2] | Vendedor       | 7%");
            Console.WriteLine("[3] | Supervisor     | 9%");
            Console.WriteLine("[4] | Motorista      | 6%");
            Console.WriteLine("[5] | Estoquista     | 5%");
            Console.WriteLine("[6] | Técnico de TI  | 8%");
            codigo = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Qual seu nome amigue ?");
            nome = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("E qual é o valor do seu salário ?");
            salario = Convert.ToSingle(Console.ReadLine());
            Console.Clear();

            switch (codigo)
            {
                case 1:
                    reajuste = (salario * 10) / 100;
                    reajuste += salario;
                    Console.WriteLine("=================");
                    Console.WriteLine($"{nome}");
                    Console.WriteLine("=================");
                    Console.WriteLine("Gerente          ");
                    Console.WriteLine("=================");
                    Console.WriteLine($"{reajuste:c}    ");
                    Console.WriteLine("=================");
                    Console.ReadKey();
                    break;

                case 2:
                    reajuste = (salario * 7) / 100;
                    reajuste += salario;
                    Console.WriteLine("=================");
                    Console.WriteLine($"{nome}");
                    Console.WriteLine("=================");
                    Console.WriteLine("Vendedor          ");
                    Console.WriteLine("=================");
                    Console.WriteLine($"{reajuste:c}    ");
                    Console.WriteLine("=================");
                    Console.ReadKey();
                    break;

                case 3:
                    reajuste = (salario * 9) / 100;
                    reajuste += salario;
                    Console.WriteLine("=================");
                    Console.WriteLine($"{nome}");
                    Console.WriteLine("=================");
                    Console.WriteLine("Supervisor          ");
                    Console.WriteLine("=================");
                    Console.WriteLine($"{reajuste:c}    ");
                    Console.WriteLine("=================");
                    Console.ReadKey();
                    break;

                case 4:
                    reajuste = (salario * 6) / 100;
                    reajuste += salario;
                    Console.WriteLine("=================");
                    Console.WriteLine($"{nome}");
                    Console.WriteLine("=================");
                    Console.WriteLine("Motorista          ");
                    Console.WriteLine("=================");
                    Console.WriteLine($"{reajuste:c}    ");
                    Console.WriteLine("=================");
                    Console.ReadKey();
                    break;

                case 5:
                    reajuste = (salario * 5) / 100;
                    reajuste += salario;
                    Console.WriteLine("=================");
                    Console.WriteLine($"{nome}");
                    Console.WriteLine("=================");
                    Console.WriteLine("Estoquista          ");
                    Console.WriteLine("=================");
                    Console.WriteLine($"{reajuste:c}    ");
                    Console.WriteLine("=================");
                    Console.ReadKey();
                    break;

                case 6:
                    reajuste = (salario * 8) / 100;
                    reajuste += salario;
                    Console.WriteLine("=================");
                    Console.WriteLine($"{nome}");
                    Console.WriteLine("=================");
                    Console.WriteLine("Técnico de TI    ");
                    Console.WriteLine("=================");
                    Console.WriteLine($"{reajuste:c}    ");
                    Console.WriteLine("=================");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Poxa, essa opção não existe.");
                    Console.ReadKey();
                    break;
            }

            Console.WriteLine("Obrigade por usar o programa =)");
            Console.ReadKey();
        }
    }
}