using System;

namespace input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username:");

            string nome = Console.ReadLine() ?? string.Empty; // Usando o operador ?? para tratar o valor nulo

            Console.WriteLine("Username is: " + nome);
        }
    }
}
