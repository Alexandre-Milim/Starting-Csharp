using System;

interface IAnimal //Sempre coloca esse I no inicio pra identificar melhor que é uma interface
{
  void animalSound(); 
}

class Pig : IAnimal 
{
  public void animalSound() 
  {
    Console.WriteLine("The pig says: wee wee");
  }
}

class Program 
{
  static void Main(string[] args) 
  {
    Pig myPig = new Pig(); 
    myPig.animalSound();
  }
}

/*a interface tambem não consegue criar objetos, então ela tem que ser herdada, poder usar metodos mas eles não teram conteudo ex e não precisa do override
interface IExemplo
{
    void Metodo1();
}

class MinhaClasse : IExemplo
{
    public void Metodo1()
    {
        Console.WriteLine("Implementação do Método1");
    }
}

class Program
{
    static void Main(string[] args)
    {
        MinhaClasse obj = new MinhaClasse();
        obj.Metodo1(); Saída do metodo 1
    }
}

*/