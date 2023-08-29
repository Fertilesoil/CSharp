namespace Exercício_01;

class Program
{
    static void Main(string[] args)
    {
        int opcao = 0;
        Queue<string> fila = new Queue<string>();

        do 
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine();
            Console.WriteLine("\t1 - Adicionar cliente na fila");
            Console.WriteLine("\t2 - Listar todos os clientes");
            Console.WriteLine("\t3 - Retirar clientes da fila");
            Console.WriteLine("\t0 - Sair");
            Console.WriteLine();
            Console.WriteLine("*******************************************");
            Console.WriteLine("\tInsira a opção desejada: ");
            opcao = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

                        switch (opcao)
            {
                case 1:
                    Console.WriteLine("Insira o nome do cliente: ");
                    string? nome = Console.ReadLine();
                    fila.Enqueue(nome);
                    Console.Clear();
                    break;

                case 2:
                    Console.WriteLine("Lista de clientes na fila: ");
                        foreach (var clientes in fila)
                        {
                            Console.WriteLine(clientes);
                        }
                        Console.Clear();
                    break;

                case 3:
                   if (fila.Count > 0)
                   {
                    fila.Dequeue();
                    foreach (var clientes in fila)
                        {
                            Console.WriteLine(clientes);
                        }
                        Console.WriteLine($"O cliente foi chamado!"); 
                        Console.Clear();
                   }

                   else
                   {
                        Console.WriteLine("A fila está vazia amigue!");
                        Console.Clear();
                   }
                    break;

                case 0:
                    Console.WriteLine("Programa finalizado!");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    Console.Clear();
                    break;
            }
        }
        while (opcao != 0);
        
    }
}
