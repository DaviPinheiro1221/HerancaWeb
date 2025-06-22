using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Models/Colaborador.cs
namespace ColaboradorAPI.Models
{
    public class Colaborador : Pessoa
    {
        public string? Cargo { get; set; }
        public double Salario { get; set; }

        // Construtor padrão (necessário para o model binder)
        public Colaborador()
        {
        }

        public Colaborador(string? nome, int idade, string? cargo, double salario)
        {
            Nome = nome;
            Idade = idade;
            Cargo = cargo;
            Salario = salario;
        }

    }
}