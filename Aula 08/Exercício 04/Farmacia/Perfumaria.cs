using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_04.Farmácia
{
    public class Perfumaria : Farmacia
    {
        private string nomeperfume = string.Empty;
        private string produtoperfume = string.Empty;
        private string tipoperfume = string.Empty;
        private int mls = 0;
        private string fabricante = string.Empty;

        public Perfumaria(string nomecliente, int estoque, int quantidadecompra,
            int setor, int formapagamento, string nomeperfume, string produtoperfume, string tipoperfume, int mls, string fabricante)
        : base(nomecliente, estoque, quantidadecompra, setor, formapagamento)
        {
            this.nomeperfume = nomeperfume;
            this.produtoperfume = produtoperfume;
            this.tipoperfume = tipoperfume;
            this.mls = mls;
            this.fabricante = fabricante;
        }

        public string GetNome()
        { return this.nomeperfume; }

        public void SetNome(string nome)
        { this.nomeperfume = nome; }

        public string GetProdutoperfume()
        { return this.produtoperfume; }

        public void SeProdutoperfume(string produtoperfume)
        { this.produtoperfume = produtoperfume; }

        public string GetTipo()
        { return this.tipoperfume; }

        public void SetTipo(string tipo)
        { this.tipoperfume = tipo; }

        public int GetMls()
        { return this.mls; }

        public void SetMls(int mls)
        { this.mls = mls; }

        public string GetFabricante()
        { return this.fabricante; }

        public void SetFabricante(string fabricante)
        { this.fabricante = fabricante; }


    }


}
