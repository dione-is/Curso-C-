

namespace Pensionato {
    class Cliente {

        public string nome { get; set; }
        public string email { get; set; }
        public int quarto { get; set; }


        public Cliente(string nome, string email, int quarto) {
            
            this.nome = nome;
            this.email = email;
            this.quarto = quarto;

        }

        public override string ToString() {

            return "Cliente: "
                    + nome
                    + ", email: "
                    + email
                    + ", quarto: "
                    + quarto; 
        }

    }
}
