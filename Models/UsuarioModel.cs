using System;

namespace POrtifolio.MUrilo.Models {
    public class UsuarioModel {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }

        public UsuarioModel (string Nome, string Email, string Senha, DateTime DataNascimento) {
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.DataNascimento = dataNascimento;
        }

        public UsuarioModel (int Id, string Nome, string Email, string Senha, DateTime DataNascimento) {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.DataNascimento = dataNascimento;
        }
    }
}