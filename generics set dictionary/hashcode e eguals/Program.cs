using System;
using System.Collections.Generic;
using hashcode_e_eguals.Entity;

namespace home {
    class Program {
        static void Main(string[] args) {

            Cliente a = new Cliente("pedro", "pedrodeLara@email.com");
            Cliente b = new Cliente("pedro", "pedroLara@email.com");

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}