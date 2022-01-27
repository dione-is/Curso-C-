using System;

namespace home {
    class Program {
        static void Main(string[] args) {

            HashSet<string> set = new HashSet<string>();

            set.Add("notbook");
            set.Add("Smarth Tv 60p");
            set.Add("playstation 5");

            foreach (string s in set) {

                Console.WriteLine(s);
            }
        }
    }
}