using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography;

namespace Exercício_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string titulo = string.Empty;

            Ingresso ingresso1 = new Ingresso("Pra Você Lembrar de Mim", 2, 12, "Rua Mario Amaral, 209, Paraíso", "18:00");
            Ingresso ingresso2 = new Ingresso("Casei, e Agora ?", 1, 16, "Rua dos Ingleses, 209, Bela Vista", "20:00");
            ingresso1.Visualizar();
            Console.WriteLine();
            ingresso2.Visualizar();
            Console.WriteLine();

            
            ingresso1.Visualizar();
            Console.WriteLine();

            Console.WriteLine();
            ingresso2.Visualizar();

            

            Console.WriteLine("Qual o nome do próximo show ??");
            titulo = Console.ReadLine()!;
            ingresso2.SetTitulo(titulo);
            ingresso2.SetGenero(3);
            ingresso2.SetClassificacao(18);
            ingresso2.SetLocal("Rua Augusta, 1129, Consolação");
            ingresso2.SetHorario("22:00");

            Console.Clear();
            Console.WriteLine();
            ingresso2.Visualizar();
            

            Vip ingresso3 = new Vip("Pra Você Lembrar de Mim", 2, 12, "Rua Mario Amaral, 209, Paraíso", "18:00", "Vip");
            ingresso3.Visualizar();
            Console.WriteLine();
            MeiaEntrada ingresso4 = new MeiaEntrada("Casei, e Agora ? ", 1, 16, "Rua dos Ingleses, 209, Bela Vista", "20:00" , "meia");
            ingresso4.Visualizar();
            Console.WriteLine();


        }
    }
}