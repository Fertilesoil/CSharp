using System.Dynamic;

namespace hash;

class Program
{
    static void Main(string[] args)
    {
        HashSet<string> setNomes = new HashSet<string>()
        {
            "Débora",
            "Luis",
            "Roberta",
            "Letrux",
            "Sho",
            "Sho",
        };

        /* O hashset ignora valores repetidos */
        foreach (var item in setNomes)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\n");

        /* Aqui adiciono um nome na lista */
        setNomes.Add("Adriano");
        setNomes.Add("Luclésia");
        setNomes.Add("Gargântua");

        foreach (var item in setNomes)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\n");

        /* Aqui quero saber se o nome existe na lista */
        Console.WriteLine("O nome da Julia está na lista?" + setNomes.Contains("Julia"));

        Console.WriteLine("\n");

        /* Aqui removo um nome na lista */
        setNomes.Remove("Adriano");
        foreach(var item in setNomes)
        {
            Console.Write(item + " ");
        }

        /* Método para converter hashset em lista 
        List<string>  = new setNomes.Tolist();
        {
            
        } */
    }
}
