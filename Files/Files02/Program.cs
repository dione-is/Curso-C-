using System.IO;
using System;

namespace home {
    class Program {
        static void Main(string[] args) {

            string path = @"C:\Users\Dione\Documents\CursoAlgoritmoELogicaC#\file1.txt";
            FileStream fs = null;
            StreamReader rs = null;

            try {
                rs = File.OpenText(path);
                while (!rs.EndOfStream) {
                    string line = rs.ReadLine();
                    Console.WriteLine(line);
                }

            }
            catch (IOException e) {
                Console.WriteLine(e.Message);
            }
            finally {
                if (rs != null) { 
                    rs.Close();
                }
                if (fs != null) { 
                    fs.Close();
                }
            }

        }
    }
}