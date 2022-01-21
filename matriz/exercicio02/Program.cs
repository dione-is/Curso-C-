namespace curso;

class Program {
    static void Main(string[] args) {
        int[,] matriz;
        int coluna, linha;
        int[] vetorSomaLinha;

        Console.WriteLine("Informe o a quantide de linha da matriz");
        linha = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o a quantide de coluna da matriz");
        coluna = int.Parse(Console.ReadLine());

        matriz = new int[linha, coluna];
        vetorSomaLinha = new int[linha];

        for (int i = 0; i < linha; i++) {
            string[] s = Console.ReadLine().Split(' ');
            for (int j = 0; j < coluna; j++) {
                matriz[i, j] = int.Parse(s[j]);
                vetorSomaLinha[i] += matriz[i, j];
            }
        }

        Console.WriteLine("soma de valores por linha: ");
        for (int i = 0; i < vetorSomaLinha.Length; i++) {
            Console.WriteLine(vetorSomaLinha[i]);
        }

    }
}