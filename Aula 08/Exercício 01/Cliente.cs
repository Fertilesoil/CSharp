using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DoCliente
{
    public class Cliente
    {
        private string cpf;
        private float altura;
        private int idade;
        private string nome;
        private string sexo;

        public Cliente(string cpf, float altura, int idade, string nome, string sexo)
        {
            this.cpf = cpf;
            this.altura = altura;
            this.idade = idade;
            this.nome = nome;
            this.sexo = sexo;
        }

        public string GetCpf()
        {
            return cpf;
        }

        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public float GetAltura()
        {
            return altura;
        }

        public void SetAltura(float altura)
        {
            this.altura = altura;
        }

        public int GetIdade()
        {
            return idade;
        }

        public void SetIdade(int idade)
        {
            this.idade = idade;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetSexo()
        {
            return sexo;
        }

        public void SetSexo(string sexo)
        {
            this.sexo = sexo;
        }


        public void Visualizar()
        {
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Cpf : " + this.cpf);
            Console.WriteLine("Altura: " + this.altura);
            Console.WriteLine("Idade: " + this.idade);
            Console.WriteLine("Sexo: " + this.sexo);
        }

    }
}
