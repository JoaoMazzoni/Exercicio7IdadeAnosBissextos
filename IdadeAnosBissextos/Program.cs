using IdadeAnosBissextos;
using System.Runtime.CompilerServices;


public class Program
{

    internal static void Main(string[] args)
    {
        while (true)
        {
            Pessoa pessoa = criarPessoa();
            Console.WriteLine(pessoa.ToString());
            Console.ReadLine();
            pessoa.idadeBissexto();
            Console.ReadLine();
            Console.Clear();
        }
    }

    static Pessoa criarPessoa()
    {
        string nome;
        string profissao;
        int idade;
        Console.Write("\nInforme o nome: ");
        nome = Console.ReadLine();
        Console.Write("\nInforme a profissão: ");
        profissao = Console.ReadLine();
        Console.Write("\nInforme a idade que foi ou será completada no ano atual: ");
        idade = int.Parse(Console.ReadLine());

        return new Pessoa(nome, profissao, idade);


    }


    
}