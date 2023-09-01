namespace DoCliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente( "156.287.367.90", 1.78F, 34, "Cuca Geraldo", "Masculino");
            Cliente c2 = new Cliente("359.292.347.00", 1.25F, 56, "Marina Moledo", "Masculino");

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            c1.Visualizar();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            c2.Visualizar();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            c1.SetSexo("Não Binarie");
            c1.Visualizar();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            c2.SetCpf("157.827.654.43");
            c2.SetAltura(1.74F);
            c2.Visualizar();
        }
    }
}