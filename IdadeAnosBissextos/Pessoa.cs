
namespace IdadeAnosBissextos
{
    internal class Pessoa
    {
        string nome;
        string profissao;
        int idade;

        public Pessoa(string nome, string profissao, int idade)
        {
            this.nome = nome;
            this.profissao = profissao;
            this.idade = idade;
        }


        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setProfissao(string profissao)
        {
            this.profissao = profissao;
        }

        public string getProfissao()
        {
            return this.profissao;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        public int getIdade()
        {
            return this.idade;
        }

        public void idadeBissexto()
        {
            DateTime dataAtual;
            dataAtual = DateTime.Now;
            int anoAtual = dataAtual.Year;
            int idade = this.getIdade();
            int anoNascimento;

            Console.WriteLine("\nO ano atual é: " + anoAtual);

            anoNascimento = anoAtual - idade;
            Console.WriteLine($"\nO ano de nascimento da pessoa é: {anoNascimento}");

            //Calcular idade em anos bissextos
            float IdadeEmBissextos = ((anoAtual - anoNascimento) + 1) / 4;
            Console.WriteLine("\nA idade da pessoa em anos bissextos é: {0} anos", IdadeEmBissextos);

        }

        public override string? ToString()
        {
            return $"\nNome: {this.nome}\nProfissão: {this.profissao}\nIdade: {this.idade} anos";
        }
    
    }


}
