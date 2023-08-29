namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor01 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] vetor02 = new int[5];
            string[] vetor3 = { "Paloma", "Sandy", "Raluca", "Tenório", "Valéria",
            "Genéfrio", "Gregório"};

            for (int indice = 0; indice < vetor01.Length; indice++)
            {
                Console.WriteLine($"vetor01[{indice}] = {vetor01[indice]}");
            }

            Console.WriteLine("\n");

            for (int indice = 0; indice < vetor02.Length; indice++)
            {
                Console.Write($"vetor02[{indice}] = ");
                vetor02[indice] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } 

            Array.Sort(vetor02);
            
            for (int indice = 0; indice < vetor02.Length; indice++)
            {
                Console.WriteLine($"vetor02[{indice}] = {vetor02[indice]}");
            }

            Console.WriteLine("\n");
            Array.Reverse(vetor02);
            
            for (int indice = 0; indice < vetor02.Length; indice++)
            {
                Console.WriteLine($"vetor02[{indice}] = {vetor02[indice]}");
            }

            Array.Sort(vetor3);

            for (int indice = 0; indice < vetor3.Length; indice++)
            {
                Console.WriteLine($"vetor03 [{indice}] = {vetor3[indice]}");
            }

            Console.WriteLine("A posição 2 é igual à " + Array.IndexOf(vetor3, "Valéria"));
            Console.Clear();
            
            Console.WriteLine("A posição 2 é igual à " + Array.BinarySearch(vetor3, "Valéria"));
            Console.ReadKey();

            for (int indice = 0; indice < vetor01.Length; indice++)
            {
                if (vetor01[indice] % 2 == 0)
                Console.WriteLine($"vetor01[{indice}] = {vetor01[indice]}");
            }
        }
    }
}