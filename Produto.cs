using System;
using System.Drawing;
using System.Globalization;
namespace Course
{
    public class Produto
    {
        private string _nome; // MANIPULADO MANUALMENTE
        private float Valor { get; set; } // MANIPULADO AUTOMATICAMENTE
        private int Quantidade { get; set; }

        public Produto() //CONSTRUTOR PADRÃO
        {
        }
        public Produto(string nome, float preco, int quantidade) // SOBRCARGA
        {
            _nome = nome;
            Valor = preco;
            Quantidade = quantidade;
        }
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }


        public double Valortotal()
        {
            return Valor * Quantidade;
        }

        public void Alterar(int quantidade)
        {
            if (quantidade > 0)
            {
                Quantidade += quantidade;
            }
            else
            {
                Quantidade -= quantidade;
            }
        }
        public override string ToString()
        {
            return "\nNome: " + _nome +
                   "\nValor: R$" + Valor +
                   "\nQuantidade: " + Quantidade +
                   "\nValor em estoque: R$" + Valortotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}