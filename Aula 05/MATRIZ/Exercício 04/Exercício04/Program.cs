namespace Exercício04;

class Program
{
    static void Main(string[] args)
    {
        string? [] nomes = { "Jandira", "Tuca", "Lucélia", "Paula", "Amélia",
         "Bianca", "Mary", "Gustavo", "Luisano", "Brenda"};

         float [,] notasBimestre = new float [10,4];
         float [] mediasBimestre = new float [10];
         float media = 0, soma = 0;
        
         for (int linha = 0; linha < Math.Sqrt(notasBimestre.GetLength(0)); linha++)
         {
            for (int coluna = 0; coluna < Math.Sqrt(notasBimestre.GetLength(1)); coluna++)
            {
                Console.WriteLine($"Insira as notas dos bimestres: ");
                notasBimestre[linha , coluna] = Convert.ToSingle(Console.ReadLine());
            }
         }

         for (int linha = 0; linha < Math.Sqrt(notasBimestre.GetLength(0)); linha++)
         {
            for (int coluna = 0; coluna < Math.Sqrt(notasBimestre.GetLength(1)); coluna++)
            {
                soma += notasBimestre[linha,coluna];
                media = notasBimestre[linha,coluna] / 4;
            }

            mediasBimestre[0] = media;
            soma = 0;
         }
               
         Console.WriteLine($"As médias dos bimestres são: {mediasBimestre:F1}");
    }
}
