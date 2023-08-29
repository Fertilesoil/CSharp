namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> notas = new List<double>();
            {
                /* Inserção de dados na lista */
                notas.Add(7.0);
                notas.Add(5.0);
                notas.Add(4.0);
                notas.Add(7.0);
                notas.Add(10.0);

                foreach (double nota in notas)
                {
                    Console.Write(nota + " ");
                }

                Console.WriteLine("\nPosição da nota 4.0: " + notas.IndexOf(4.0));

                /* Retorna o valor do índice */
                Console.WriteLine("\nA nota 4.0 existe ?: " + notas.Contains(4.0));

                /* Remove um elemento */
                notas.Remove(4.0); 

                 Console.WriteLine("\nA nota 4.0 existe ?: " + notas.Contains(4.0));

                 foreach (double nota in notas)
                {
                    Console.Write(nota + " ");
                }

                /* Acha a posição da nota na lista */
                Console.WriteLine("\nPosição da nota 10.0: " + notas.IndexOf(10.0));
                
                /* Conta os elementos */
                Console.WriteLine("\nQuantos elementos tenho na minha lista? " + notas.Count());
                
                /* Ordenar as notas */
                notas.Sort();

                foreach (double nota in notas)
                {
                    Console.Write(nota + " ");
                }
                
                /* Reverter a ordem dos elementos */
                notas.Reverse();    

                foreach (double nota in notas)
                {
                    Console.Write(nota + " ");
                }

                /* Alteração das notas */
                notas[0] = 9.0;

                /* O var dentro do foreach identiica o tipo da variável original e faz uma 
                conversão implícita */
                foreach (var nota in notas)
                {
                    Console.Write(nota + " ");
                }
            }
        }
    }
}