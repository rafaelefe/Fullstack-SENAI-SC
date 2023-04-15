namespace exercicio_01_06.Classes
{
    public class Cliente
    {
        // exercicio 1
        public string nome { get; private set; }
        public DateTime nascimento { get; private set; }
        public string profissao { get; private set; }
        public string estadoCivil { get; private set; }
        public TipoPessoaEnum tipoPessoa { get; private set; }

        public Cliente(string nome, DateTime nascimento, string profissao, string estadoCivil, TipoPessoaEnum tipoPessoa)
        {
            this.nome = nome;
            this.nascimento = nascimento;
            this.profissao = profissao;
            this.estadoCivil = estadoCivil;
            this.tipoPessoa = tipoPessoa;
        }
    }
}
