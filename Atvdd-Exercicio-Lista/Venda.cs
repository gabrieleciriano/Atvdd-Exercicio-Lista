using System.Collections.Generic;

namespace Atvdd_Exercicio_Lista
{
    public sealed class Venda
    {
        public Venda(int id, DateTime dataVenda, List<Produto> lstaProdutos)
        {
            Id = id;
            DataVenda = dataVenda;
            ListaProdutos = lstaProdutos;
        }

        private int Id;
        private DateTime DataVenda;
        private List<Produto> ListaProdutos;

        public void ImprimirDadosVenda()
        {
            Console.WriteLine($"\n>>>DADOS DA VENDA<<<\n");
            Console.WriteLine($" ID da venda: {Id}");
            Console.WriteLine($" Data em que a venda foi realizada: {DataVenda.ToString("dd/MM/yyyy")}");
            Console.WriteLine($" Produtos adquiridos pelo cliente: \n");

            foreach (var item in ListaProdutos)
            {
                Console.WriteLine(item.ImprimirDadosProduto());
            }
        }
    }

}