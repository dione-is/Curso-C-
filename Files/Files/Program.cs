using System;
using System.IO;

namespace home {
    class Program {
        static void Main(string[] args) {

            string sourcePath =  @"C:\Users\Dione\Documents\CursoAlgoritmoELogicaC#\file1.txt";
            string targetPath = @"C:\Users\Dione\Documents\CursoAlgoritmoELogicaC#\file2.txt";

            try {
                FileInfo fi = new FileInfo(sourcePath);
               // fi.CopyTo(targetPath); cria uma copia de outor arquivo;
                string[] vetFile = File.ReadAllLines(sourcePath);

                for (int i = 0; i < vetFile.Length; i++) {
                    
                    Console.WriteLine(vetFile[i]);
                }

            }
            catch (IOException e) {
                Console.WriteLine("um erro ocorreu: ");
                Console.WriteLine(e.Message);
            }

        }
    }
}