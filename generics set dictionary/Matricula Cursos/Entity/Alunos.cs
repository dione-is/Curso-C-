using System;
using System.Collections.Generic;

namespace Matricula_Cursos.Entity {
    class Alunos {
        public int Matricula { get; set; }
        public string Nome { get; set; }

        public Alunos(int matricula, string nome) {
            Matricula = matricula;
            Nome = nome;
        }

        public override bool Equals(object? obj) {
            return obj is Alunos alunos &&
                   Matricula == alunos.Matricula;
        }

        public override int GetHashCode() {
            return HashCode.Combine(Matricula);
        }
    }
}
