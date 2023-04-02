namespace Atvdd_Exercicio_Lista
{
    public sealed class Endereco
    {
        public Endereco(string rua, string numero, string bairro, string cep, string cidade, string estado)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cep = cep;
            Cidade = cidade;
            Estado = estado;
        }

        private string Rua;
        private string Numero;
        private string Bairro;
        private string Cep;
        private string Cidade;
        private string Estado;


        public string getRua()
        {
            return Rua;
        }

        public void setRua(string rua)
        {
            Rua = rua;
        }

        public string getNumero()
        {
            return Numero;
        }

        public void setNumero(string numero)
        {
            Numero = numero;
        }

        public string getBairro()
        {
            return Bairro;
        }

        public void setBairro(string bairro)
        {
            Bairro = bairro;
        }

        public string getCep()
        {
            return Cep;
        }
        public void setCep(string cep)
        {
            Cep = cep;
        }

        public string getCidade()
        {
            return Cidade;
        }

        public void setCidade(string cidade)
        {
            Cidade = cidade;
        }

        public string getEstado()
        {
            return Estado;
        }

        public void setEstado(string estado)
        {
            Estado = estado;
        }

        public string EnderecoCompleto()
        {
            return $"{Rua}, {Numero} Bairro: {Bairro} Cidade: {Cidade} / {Estado}";

        }
    }
}