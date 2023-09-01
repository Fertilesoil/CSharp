using Exercício_04.Farmacia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_04
{
    public class Farmacia
    {
        private string nomecliente = string.Empty;
        private int estoque;
        private int quantidadecompra;
        private int setor;
        private int formapagamento;

        public Farmacia(string nomecliente, int estoque, int quantidadecompra, int setor, int formapagamento)
        {
            this.nomecliente = nomecliente;
            this.estoque = estoque;
            this.quantidadecompra = quantidadecompra;
            this.setor = setor;
            this.formapagamento = formapagamento;
        }

        public string GetNomecliente() 
        { return nomecliente; }

        public void SetNomecliente(string nomecliente)
        { this.nomecliente = nomecliente; }

        public int GetEstoque()
        { return estoque; }

        public void SetEstoque(int estoque)
        { this.estoque = estoque; }

        public int GetQuantidadecompra()
        { return quantidadecompra; }

        public void SetQuantidadecompra(int quantidadecompra)
        { this.quantidadecompra = quantidadecompra; }

        public int GetProduto()
        { return setor; }

        public void SetProduto(int setor)
        { this.setor = setor; }

        public int GetFormapagamento()
        { return formapagamento; }

        public void SetFormapagamento(int formapagamento)
        { this.formapagamento = formapagamento; }

        public virtual void Visualizar()
        {
            string tipoproduto = string.Empty;
            switch (this.setor)
            {
                case 1:
                    tipoproduto = "Medicamento.";
                    break;

                case 2:
                    tipoproduto = "Perfumaria.";
                    break;

                default:
                    tipoproduto = "Calma, vamos chegar lá!";
                    break;
            }

            string tipopagamento = string.Empty;
            switch (this.formapagamento)
            {
                case 1:
                    tipopagamento = "Cartão.";
                    break;

                case 2:
                    tipopagamento = "Pix.";
                    break;

                default:
                    tipopagamento = "Dinheiro.";
                    break;
            }

            Console.WriteLine("ººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººº");
            Console.WriteLine($"      O nome do cliente é : {this.nomecliente}");
            Console.WriteLine("ººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººº");
            Console.WriteLine($"      Quantidade do produto em estoque: {this.estoque}");
            Console.WriteLine("ººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººº");
            Console.WriteLine($"      Quantidade solicitada do produto: {this.quantidadecompra}");
            Console.WriteLine("ººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººº");
            Console.WriteLine($"      Produto do tipo: {tipoproduto}");
            Console.WriteLine("ººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººººº");
            Console.WriteLine($"      Forma de pagamento: {tipopagamento}");
            
        }
    }
}
