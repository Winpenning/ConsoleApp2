using System;
using System.Drawing;
using System.Globalization;

namespace Course
{
    class Principal
    {
        static void Main(string[] args)
        {
            int op = 0, quantidade;
            float valor;
            string nome;

            Console.Write("Digite o nome do produto: ");
            nome = Console.ReadLine();

            Console.Write("Digite o preço do produto: ");
            valor = float.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade do produto: ");
            quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, valor, quantidade);
            Console.WriteLine("\nProduto cadastrado\n");
            while(op !=3)
            {
                Console.WriteLine("\n\nGostaria de realizar outra operação?\n 0 - Ver dados do produto\n 1 - Adicionar\n 2 - Remover\n 3 - Sair");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        Console.WriteLine(p);
                        break;

                    case 1:
                        Console.Write("Digite quantos produtos gostaria de adicionar\n--> ");
                        quantidade= int.Parse(Console.ReadLine());

                        p.Adicionar(quantidade);
                        break;

                    case 2:
                        Console.Write("Digite quantos produtos gostaria de remover\n--> ");
                        quantidade= int.Parse(Console.ReadLine());

                        p.Remover(quantidade);
                        break;

                    case 3:
                        op = 3;
                        break;

                    default: 
                        Console.WriteLine("Operação inválida!");
                        break;
                }
            }
            

            
        }
    }
}