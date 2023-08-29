namespace Exercício_02;

class Program
{
    static void Main(string[] args)
    {
        int opcao = 0;
        Stack<string> pilha = new Stack<string>();

        do
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("");
            Console.WriteLine("\t1 - Adicionar livro na pilha");
            Console.WriteLine("\t2 - Listar todos os livros");
            Console.WriteLine("\t3 - Retirar livro da pilha");
            Console.WriteLine("\t0 - Sair");
            Console.WriteLine("");
            Console.WriteLine("*******************************************");
            Console.Write("\tInsira a opção desejada: ");
            opcao = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (opcao) 
            {
                case 1:
                Console.WriteLine("Qual seria seu livro ?");
                pilha.Push(Console.ReadLine()!);
                Console.Clear();
                   break;

                case 2:
                Console.WriteLine("Lista de livros na pilha");
                foreach (var livros in pilha)
                {
                    Console.WriteLine(livros);
                }
                   break;

                case 3:
                if (pilha.Count > 0)
                {
                    pilha.Pop();
                    foreach (var livros in pilha)
                {
                    Console.WriteLine(livros);
                }
                Console.WriteLine("Um livro foi retirado da pilha.");
                }

                else
                {
                    Console.WriteLine("A pilha está vazia");
                }
                   break;

                case 0:
                Console.WriteLine("Programa finalizado!");
                   break;

                default:
                Console.WriteLine("Opção inválida!");
                   break;
            }

        }while(opcao != 0);
        

    }
}
