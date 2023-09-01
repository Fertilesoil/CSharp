using Exercício_04.Farmácia;

namespace Exercício_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Medicamento medicamento0 = new Medicamento("Junno", "Branca", "200mg - 14 Capsulas Moles", 61.20F, "Farmoquímica"); 
            Medicamento medicamento1 = new Medicamento("Meal","Branca - Somente sob prescrição médica. 2 Vias com retenção de uma.","10mg - " +
                "30 comprimidos revestidos.", 58.40F ,"Torrent");


            medicamento0.Visualizar();
            Console.WriteLine();
            medicamento1.Visualizar();
        }
    }
}