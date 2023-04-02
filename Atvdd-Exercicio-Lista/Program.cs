using Atvdd_Exercicio_Lista;

List<Produto> listaProdutos = new List<Produto>();
Venda venda = new Venda(1, DateTime.Now, listaProdutos);

for (int i = 0; i < 10; i++)
{
    Produto produto = new Produto(i + 1, (i * 2) + 3, $"produto Nº {i + 1}");
    listaProdutos.Add(produto);
}

venda.ImprimirDadosVenda();