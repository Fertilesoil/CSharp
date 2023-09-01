using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_05
{
    public class MeiaEntrada : Ingresso
    {
        private string meia = string.Empty;
        public MeiaEntrada(string titulo, int genero, int classificacao, string local, string horario, string meia)
        : base(titulo, genero, classificacao, local, horario)
        {
            this.meia = meia;
        }

        public string GetMeia()
        { return  meia; }

        public void SetMeia(string meia)
        { this.meia = meia; }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("                         Meia Entrada                         ");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("    Apresente o documento que você selecionou na entrada do   ");
            Console.WriteLine("        Teatro para a confirmação de sua meia entrada.        ");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
        }
    }
}

