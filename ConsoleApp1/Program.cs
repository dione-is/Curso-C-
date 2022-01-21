using System.Globalization;
using System;


// See https://aka.ms/new-console-template for more information
double valor = 111.2222;
double peso = 80.500;
int    idade  = 28;
char sexo = 'M';

Console.WriteLine("Hello, World!");

Console.WriteLine(valor.ToString("F3"));

Console.WriteLine(valor.ToString("F1", CultureInfo.InvariantCulture));

Console.WriteLine("Dione Santos tem " + idade + " anos e " + peso.ToString("F1") + " kilos");
