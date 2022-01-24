using System;

namespace Publicacao.entity {
    class Comment {

        public string text { get; private set; }

        public Comment() { 
        
        }

        public Comment(string text) {
            this.text = text;
        }
    }
}
