using System;

class Program
{
    static void Main(string[] args)
    {
        try // try é um bloco de codigo que vai retornar as catchs
        {
            int[] myNumbers = { 1, 2, 3 };
            Console.WriteLine(myNumbers[4]); // o erro vai estar aqui, pq não tem posição 4 na lista acima
        }
        catch (Exception e) //as catchs tem que ter Exception, o e é uma varivel pra usar a abaixo junto com Message, isso quando for msg de erro, senão não tem nada de varivel
        {
            Console.WriteLine("ocorreu um erro " + e.Message); // e o Message é pra exibir a msg de erro
        }
		finally{
			Console.WriteLine("fim do programa"); //vai ser executado independente dos resultados da try
		}
    }
}