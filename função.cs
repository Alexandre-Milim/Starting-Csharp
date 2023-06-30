using System;

class Program
{
    static void Main(string[] args)// nome do metodo (Main) não pode ser mudado, e quando inicia o programa começa por ele, mas ele pode estar no fim ou no meio
    {
        Pessoa pessoinha = new Pessoa(); //ele pega a minha classe que esta la embaixo e cria um objeto, ela vai passar uma variavel, no caso a pessoa minusculo, e essa variavel vai receber a classe Pessoa, e assim vai poder usar a variavel com as funções/metodos
        pessoinha.DigitarNome();
        pessoinha.ImprimirNome();
        pessoinha.ImprimirAdjetivo();
    }

    class Pessoa
    {
        private string nome;

        public void DigitarNome()
        {
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write(ImprimirNome() + nome + ImprimirAdjetivo()); //pra poder pegar os metodos coloquei eles em ()
        }

        public string ImprimirNome() // pra poder usar o return inves de eu declarar  public como void, fiz por string
        {
            return "o ";
        }

        public string ImprimirAdjetivo() // pra poder usar o return inves de eu declarar  public como void, fiz por string
        {
            return " é lindo";
        }
    }
}
