using System;
using System.Drawing;
using System.Globalization;

namespace Course
{
    class Principal
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o preço do produto: ");
            float valor = float.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade do produto: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, valor, quantidade);
            Console.WriteLine(p);
        }
    }
}