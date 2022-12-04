using System;
using System.Drawing;
using System.Globalization;
namespace Course
{
    public class Produto
    {
        private float Valor { get; set; }
        private int Quantidade { get; set; }

        private string _nome;

        public Produto(string nome, float preco, int quantidade)
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
        public void Remover(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public void Adicionar(int quanidade)
        {
            Quantidade+= quanidade;
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