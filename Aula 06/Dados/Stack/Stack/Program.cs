namespace Stack;

class Program
{
    static void Main(string[] args)
    {
        Stack<string> pilha = new Stack<string>();
        /* Aqui você adiciona um nome na lista */
            pilha.Push("Breno");
            pilha.Push("Eduardo");
            pilha.Push("Julia");
            pilha.Push("Leonardo");
            pilha.Push("Gaspar");

            foreach (var item in pilha)
            {
                Console.Write(item + " | " ) ;
            }

            Console.WriteLine("\n");
        /* Aqui você tira um nome na lista */
        pilha.Pop();

         foreach (var item in pilha)
            {
                Console.Write(item + " | " ) ;
            }

        Console.WriteLine("");
        Console.WriteLine("Último da pilha: " + pilha.Peek());
        Console.WriteLine("");
        Console.WriteLine("O gaspar faz parte da pilha?" + pilha.Contains("Gaspar"));
        Console.WriteLine("");
        Console.WriteLine("Número de pessoas na pilha: " + pilha.Count());
    }
}
