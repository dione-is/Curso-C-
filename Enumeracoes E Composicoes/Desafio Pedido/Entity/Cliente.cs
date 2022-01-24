using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Pedido.Entity
{
    class Cliente
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public DateTime DataNascimento { get; private set; }

        public Cliente() {

        }

        public Cliente(string nome, string email, DateTime dataNasc) {
            Nome = nome;
            Email = email;
            DataNascimento = dataNasc;
        }

        public override string ToString() {
            return   Nome
                    + " ("
                    + DataNascimento
                    + ") - "
                    + Email;
        }
    }
}
