using System;
using System.Globalization;
using Desafio_Pedido.Entity;
using Desafio_Pedido.Entity.Enums;
using System.Text;

namespace Principal {
    class Program {
        static void Main(string[] args) {

            Pedido pedido = new Pedido();
            ItemPedido itemPedido = new ItemPedido();
            Cliente cliente = new Cliente();
            Produto produto = new Produto();

            Console.WriteLine("informe o nome do Cliente");
            String nome = Console.ReadLine();
            Console.WriteLine("Informe o email do cliente");
            string email = Console.ReadLine();
            Console.WriteLine("informe a data de nascimento");
            string data = Console.ReadLine();
            DateTime dataNascimento = DateTime.Parse(data);
            cliente = new Cliente(nome, email, dataNascimento);

            StatusOrdem status = StatusOrdem.Processando;
            DateTime dataPedido = DateTime.Now;
            pedido = new Pedido(dataPedido, status, cliente);
            Console.WriteLine();

            Console.WriteLine("quantos itens deseja adicionar ?");
            int opcao = int.Parse(Console.ReadLine());

            for (int i = 0; i < opcao; i++) {

                Console.WriteLine("Informe nome e preco do produto");
                string nomeProduto = Console.ReadLine();
                double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                int quantidade = int.Parse(Console.ReadLine());

                produto = new Produto(nomeProduto, precoProduto);
                itemPedido = new ItemPedido(quantidade, precoProduto, produto);
                pedido.AdicionarItem(itemPedido);

            }

            Console.WriteLine();
            Console.WriteLine("PEDIDO");
            Console.WriteLine(pedido);            

        }
    }
}