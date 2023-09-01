using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_02.Funcionário
{
    public class Funcionario
    {
        private int id;
        private string nome = string.Empty;
        private float salario;
        private string funcao = string.Empty;
        private int turno;
        private int ativo = 0;

        public Funcionario(int id, string nome, float salario, string funcao, int turno, int ativo)
        {
            this.id = id;
            this.nome = nome;
            this.salario = salario;
            this.funcao = funcao;
            this.turno = turno;
            this.ativo = ativo;
        }

        public int GetId()
        { return id; }

        public void SetId(int id)
        { this.id = id; }

        public string GetNome()
        { return nome; }

        public void SetNome(string nome)
        { this.nome = nome; }

        public float GetSalario()
        { return salario; }

        public void SetSalario(float salario)
        { this.salario = salario; }

        public string GetFuncao()
        { return funcao; }

        public void SetFuncao(string funcao)
        { this.funcao = funcao; }

        public int GetTurno()
        { return turno; }

        public void SetTurno(int turno)
        { this.turno = turno; }

        public int GetAtivo()
        { return ativo; }

        public void SetAtivo(int ativo)
        { this.ativo = ativo; }


        public void Visualizar()
        {
            int estado = this.ativo;
            string estadoString = string.Empty;
            if (estado == 0)
            {
                estadoString = "Ativo";
            }
            else if (estado != 0)
            { 
                estadoString = "Inativo";
            }

            string turno = string.Empty;
            switch (this.turno)
            {
                case 1:
                    turno = "Manhã";
                    break;

                case 2:
                    turno = "Tarde";
                    break;

                case 3:
                    turno = "Noite";
                    break;
            }

            Console.WriteLine($"O ID do funcionário é : {this.id}");
            Console.WriteLine($"O nome do funcionário é: {this.nome}");
            Console.WriteLine($"O salário de {this.nome} está em: {this.salario:c}");
            Console.WriteLine($"A função de {this.nome} é: {this.funcao}");
            Console.WriteLine($"O turno do funcionário é {turno}");
            Console.WriteLine($"O cadastro de {this.nome} está {estadoString}");
        }
    }
}




