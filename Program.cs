using System;

namespace ProdutoNomePreçoQuantidadeCOO
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite o nome do produto:");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine("Digite o preço unitário do produto:");
            double precoUnitario;
            while (!double.TryParse(Console.ReadLine(), out precoUnitario) || precoUnitario <= 0)
            {
                Console.WriteLine("Preço inválido. Digite novamente:");
            }

            Console.WriteLine("Digite a quantidade desejada:");
            int quantidade;
            while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade <= 0)
            {
                Console.WriteLine("Quantidade inválida. Digite novamente:");
            }

            Produto produto = new Produto(nomeProduto, precoUnitario, quantidade);
            produto.CalcularDesconto();
            produto.ImprimirDados();
        }
    }

    class Produto
    {
        public string Nome;
        public double PrecoUnitario;
        public int Quantidade;
        public double Desconto;
        public double ValorTotal;
        public double ValorDesc;

        public Produto(string nome, double precoUnitario, int quantidade)
        {
            Nome = nome;
            PrecoUnitario = precoUnitario;
            Quantidade = quantidade;
        }

        public void CalcularDesconto()
        {
            if (Quantidade > 50)
            {
                Desconto = 0.25;
            }
            else if (Quantidade > 20)
            {
                Desconto = 0.20;
            }
            else if (Quantidade > 10)
            {
                Desconto = 0.10;
            }

            ValorTotal = PrecoUnitario * Quantidade * (1 - Desconto);
            ValorDesc = PrecoUnitario * Quantidade * Desconto;
        }

        public void ImprimirDados()
        {
            Console.WriteLine($"Nome do produto: {Nome}");
            Console.WriteLine($"Preço unitário do produto: R${PrecoUnitario:F2}");
            Console.WriteLine($"Quantidade desejada: {Quantidade}");
            Console.WriteLine($"Valor total do produto: R${ValorTotal:F2}");
            Console.WriteLine($"Valor total do desconto: R${ValorDesc:F2}");
        }
    }
}

//Faça um programa que solicite em tela para o usuario
//o nome do produto = double
//o preço unitário do produto = double
//a quantidade desejada do produto = int
//valor total do produto = double
//valor do desconto recebido na compra = double
// aplique descontos se
//quantidade maior que  50 desconto de 0.25% = double
//quantidade maior  20 desconto de 0.20 = double
//quantidade maior 10 desconto 0.10 = double
//Com orientação a objetos

