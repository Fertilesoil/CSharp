namespace fila;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> fila = new Queue<string>();
        /* Aqui você adiciona um nome na lista */
            fila.Enqueue("Breno");
            fila.Enqueue("Eduardo");
            fila.Enqueue("Julia");
            fila.Enqueue("Leonardo");
            fila.Enqueue("Gaspar");

            foreach (var item in fila)
            {
                Console.Write(item + " | " ) ;
            }

            Console.WriteLine("\n");
        /* Aqui você tira um nome na lista */
        fila.Dequeue();

         foreach (var item in fila)
            {
                Console.Write(item + " | " ) ;
            }

        Console.WriteLine("");
        Console.WriteLine("Primeiro da fila: " + fila.Peek());
        Console.WriteLine("");
        Console.WriteLine("O gaspar entrou na fila?" + fila.Contains("Gaspar"));
        Console.WriteLine("");
        Console.WriteLine("Número de pessoas na fila: " + fila.Count());

    }
}
