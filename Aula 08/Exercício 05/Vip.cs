using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_05
{
    public class Vip : Ingresso
    {
        private string vip = string.Empty;
        public Vip(string titulo, int genero, int classificacao, string local, string horario, string vip) 
        : base(titulo, genero, classificacao, local, horario)
        {
            this.vip = vip;
        }

        public string GetVip()
        { return vip; }

        public void SetVip(string vip)
        { this.vip = vip; }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("                         Ingresso Vip                         ");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine(" Esse ingresso garante acesso ao camarim por 10 Minutos após a");
            Console.WriteLine("     apresentação, não descartar e apresentá-lo na saída.     ");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
        }
    }
}

