using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaFuncao
{
    internal class Contato
    {
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }

        public Contato(string nome, int telefone, int idade, char sexo)
        {
            Nome = nome;
            Telefone = telefone;
            Idade = idade;
            Sexo = sexo;
        }

        public override string ToString()
        {
            return "Nome: " + Nome +"\nTelefone: " + Telefone + "\nIdade: " + Idade + "\nSexo: " + Sexo + "\n=======================";
        }
    }
}
