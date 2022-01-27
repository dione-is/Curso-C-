using System;
using System.Collections.Generic;


namespace log_Usuario.Entity {
    class RegistroAcesso {
        public string Nome { get; set; }
        public DateTime Horario { get; set; }
/*
        public override bool Equals(object? obj) {
            return obj is RegistroAcesso acesso &&
                   Nome == acesso.Nome;
        }

        public override int GetHashCode() {
            return HashCode.Combine(Nome);
        }*/
    }
}
