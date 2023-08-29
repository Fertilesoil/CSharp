namespace Exercício_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            int somaprincipal = 0, somasecundaria = 0;

            for (int l = 0; l < Math.Sqrt(matriz.Length); l++)
            {
                for (int c = 0; c < Math.Sqrt(matriz.Length); c++)
                {
                    Console.WriteLine("Informe seus números pessoa: ");
                    matriz[l, c] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int l = 0; l < matriz.GetLength(0); l++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    if (l == c)
                    {
                        Console.WriteLine($"A diagonal principal é : {matriz[l, c]}");
                        somaprincipal += matriz[l, c];
                    }
                }
            }

            for (int l = 0; l < matriz.GetLength(0); l++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    if ((l + c) == matriz.GetLength(0) - 1)
                    {
                        Console.WriteLine($"A diagonal secundária é : {matriz[l, c]}");
                        somasecundaria += matriz[l, c];
                    }
                }
            }


            Console.WriteLine($"A soma da diagonal secundária é: {somaprincipal}");
            Console.WriteLine($"A soma da diagonal secundária é: {somasecundaria}");


        }
    }
}