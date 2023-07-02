using System;

class Program
{
    static void checkAge(int age)
{
  if (age < 18)
  {
    throw new ArithmeticException("Acesso negado - Você deve ter pelo menos 18 anos de idade."); //throw new é um erro personalizado
  }
  else
  {
    Console.WriteLine("Acesso concedido - Você tem idade suficiente!");
  }
}

static void Main(string[] args)
{
  checkAge(15); //declarando a idade
}
}