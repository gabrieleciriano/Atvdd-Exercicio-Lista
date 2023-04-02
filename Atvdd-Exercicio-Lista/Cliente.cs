namespace Atvdd_Exercicio_Lista
{
    public sealed class Cliente
    {
        public Cliente(int id, string nome, string telefone, Endereco endereco)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;

        }

        private int Id;
        private string Nome;
        private string Telefone;
        private Endereco Endereco;


        public int getId()
        {
            return Id;
        }

        public void setId(int id)
        {
            Id = id;
        }

        public string getNome()
        {
            return Nome;
        }

        public void setNome(string nome)
        {
            Nome = nome;
        }

        public string getTelefone()
        {
            return Telefone;
        }

        public void setTelefone(string telefone)
        {
            Telefone = telefone;
        }

        public Endereco getEndereco()
        {
            return Endereco;
        }

        public void setEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }

        public string ImprimirDadosCliente()
        {
            return $"Id: {Id} Nome: {Nome} Endereço: {Endereco.EnderecoCompleto()}";
        }
    }
}