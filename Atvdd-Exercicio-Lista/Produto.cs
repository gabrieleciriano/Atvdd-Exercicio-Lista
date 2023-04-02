namespace Atvdd_Exercicio_Lista
{

    public sealed class Produto
    {
        public Produto(int id, decimal valor, string descricao)
        {
            Id = id;
            Valor = valor;
            Descricao = descricao;

        }

        private int Id;
        private decimal Valor;
        private string Descricao;

        public int getId()
        {
            return Id;
        }

        public void setId(int id)
        {
            Id = id;
        }

        public decimal getValor()
        {
            return Valor;
        }

        public void setValor(decimal valor)
        {
            Valor = valor;
        }
        public string getDescricao()
        {
            return Descricao;
        }

        public void setDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public string ImprimirDadosProduto()
        {
            return ($"- Id do produto: {Id}, Valor: {Valor}, Descricao: {Descricao}");
        }
    }
}