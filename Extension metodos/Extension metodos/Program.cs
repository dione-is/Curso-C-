using System;
using Extension_metodos.Extesion;

namespace home {
    class Program {
        static void Main(string[] args) {

            DateTime dt = new DateTime(2022, 01, 26, 18, 10, 45);

            Console.WriteLine(dt.ElapsedTime());
        }
    }
}