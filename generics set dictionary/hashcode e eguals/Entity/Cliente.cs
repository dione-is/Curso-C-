using System;
using System.Collections.Generic;


namespace hashcode_e_eguals.Entity {
    class Cliente {

        public string Nome { get; set; }
        public string Email { get; set; }

        public Cliente(string nome, string email) {
            Nome = nome;
            Email = email;
        }

        public override bool Equals(object? obj) {
            return obj is Cliente cliente &&
                   Nome == cliente.Nome &&
                   Email == cliente.Email;
        }

        public override int GetHashCode() {
            return HashCode.Combine(Nome, Email);
        }
    }
}
