using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_05
{
    public class Ingresso
    {
        private string titulo = string.Empty;
        private int genero;
        private int classificacao;
        private string local = string.Empty;
        private string horario = string.Empty;

        public Ingresso(string titulo, int genero, int classificacao, string local, string horario)
        {
            this.titulo = titulo;
            this.genero = genero;
            this.classificacao = classificacao;
            this.local = local;
            this.horario = horario;
        }

        public string GetTitulo()
        {
            return titulo;
        }

        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public int GetGenero()
        {
            return genero;
        }

        public void SetGenero(int genero)
        {
            this.genero = genero;
        }

        public int GetClassificacao()
        {
            return classificacao;
        }

        public void SetClassificacao(int classificacao)
        {
            this.classificacao = classificacao;
        }

        public string GetLocal()
        {
            return local;
        }

        public void SetLocal(string local)
        {
            this.local = local;
        }

        public string GetHorario()
        {
            return horario;
        }

        public void SetHorario(string horario)
        {
            this.horario = horario;
        }

        public virtual void Visualizar()

        {
            string genero = string.Empty;
            switch (this.genero)
            {
                case 1:
                    genero = "Comédia";
                    break;

                case 2:
                    genero = "Drama";
                    break;

                case 3:
                    genero = "Improviso";
                    break;
            }


            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("<>                          Ingresso                        <>");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine($"Título da Peça: {this.titulo}");
            Console.WriteLine($"Gênero: {genero}");
            Console.WriteLine($"Classificação Indicativa: {this.classificacao}" + " Anos");
            Console.WriteLine($"No Endereço: {this.local}");
            Console.WriteLine($"Horário: {this.horario}" + " Horas.");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");

        }
    }


}
