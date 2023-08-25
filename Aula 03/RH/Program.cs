namespace Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome;
            int cargo;
            float salario, reajuste;

            Console.WriteLine("Informe seu nome: ");
            nome = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Qual o seu cargo ?");
            Console.WriteLine("1 - Supervisor");
            Console.WriteLine("2 - Diretor");
            Console.WriteLine("3 - Gerente");
            Console.WriteLine("4 - Outros");
            cargo = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Informe seu salário: ");
            salario = Convert.ToSingle(Console.ReadLine());
            Console.Clear();

            switch (cargo)
            {
                case 1:
                    reajuste = (salario * 0.7f) /100;
                    break;
                case 2:
                    reajuste = (salario * 0.9f) / 100;
                    break;
                case 3:
                    reajuste = (salario * 5) / 100;
                    break;
                default:
                    reajuste = (salario * 12) / 100;
                    break;
            }

            Console.WriteLine($"O valor do reajuste de {nome} é: {reajuste:c}");
            Console.WriteLine($"O novo salário de {nome} é: {reajuste+salario:c}");

        }
    }
}