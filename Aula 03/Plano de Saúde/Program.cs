namespace Plano_de_Saúde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome;
            int idade;

            Console.WriteLine("Informe seu nome: ");
            nome =  Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Informe sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (idade >= 0 && idade <= 10)
            {
                Console.WriteLine("{0}, o valor de seu plano de saúde é R$100,00.",nome);
                Console.ReadKey();
                Console.Clear();
            }

            else if (idade >= 11 && idade <= 29)
            {
                Console.WriteLine("{0}, o valor de seu plano de saúde é R$200,00.", nome);
                Console.ReadKey();
                Console.Clear();
            }

            else if (idade >= 30 && idade <= 45)
            {
                Console.WriteLine("{0}, o valor de seu plano de saúde é R$300,00.", nome);
                Console.ReadKey();
                Console.Clear();
            }

            else if (idade >= 46 && idade <= 59)
            {
                Console.WriteLine("{0}, o valor de seu plano de saúde é R$500,00.", nome);
                Console.ReadKey();
                Console.Clear();
            }

            else if (idade >= 60 && idade <= 65)
            {
                Console.WriteLine("{0}, o valor de seu plano de saúde é R$600,00.", nome);
                Console.ReadKey();
                Console.Clear();
            }

            else
            {
                Console.WriteLine("{0}, o valor de seu plano de saúde é R$1000,00.", nome);
                Console.ReadKey();
                Console.Clear();
            }

            
            Console.WriteLine("\n\n\n\nObrigado por escolher nosso plano de saúde =)");



        }
    }
}