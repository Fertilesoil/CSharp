using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_04.Farmacia
{
    public class Medicamento : Farmacia
    {
        private string nome = string.Empty;
        private string faixa = string.Empty;
        private string dosagem = string.Empty;
        private float valor = 0F;
        private string fabricante = string.Empty;

        public Medicamento(string nome, string faixa, string dosagem, float valor, string fabricante)
        {
            this.nome = nome;
            this.faixa = faixa;
            this.dosagem = dosagem;
            this.valor = valor;
            this.fabricante = fabricante;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetFaixa()
        {
            return faixa;
        }

        public void SetFaixa(string faixa)
        {
            this.faixa = faixa;
        }

        public string GetDosagem()
        {
            return dosagem;
        }

        public void SetDosagem(string dosagem)
        {
            this.dosagem = dosagem;
        }

        public float GeValor()
        {
            return valor;
        }

        public void SetValor(float valor)
        {
            this.valor = valor;
        }

        public string GetFabricante()
        {
            return fabricante;
        }

        public void SetFabricante(string fabricante)
        {
            this.fabricante = fabricante;
        }

        public override void Visualizar()
        {
            base.Visualizar();
        }
            
           /* Console.WriteLine("ººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººº");
            Console.WriteLine($"      O nome do seu medicamento é: {this.nome}");
            Console.WriteLine("ººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººº");
            Console.WriteLine($"      Faixa: {this.faixa}");
            Console.WriteLine("ººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººº");
            Console.WriteLine($"      Dosagem: {dosagem}");
            Console.WriteLine("ººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººº");
            Console.WriteLine($"      Valor final: {valor:c}");
            Console.WriteLine("ººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººº");
            Console.WriteLine($"      Fabricante: {fabricante}");
            Console.WriteLine("ººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººº");
           */
    }
}
