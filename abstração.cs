using System;

abstract class Animal
{
  public abstract void animalSound(); 
  public  void sleep()
  {
    Console.WriteLine("Zzz");
  }
}

class Pig : Animal // como a classe de cima esta abstrata, o jeito que vc consegue usar ela é herdando ela
{
  public override void animalSound() // o override esta quebrando a abstract, para conseguir exibir, diferente da função sleep que exibe de boa
  {
    Console.WriteLine("o porco faz: wee wee");
  }
}

class Program
{
  static void Main(string[] args)
  {
    Pig myPig = new Pig(); 
    myPig.animalSound();    
    myPig.sleep();  
  }
}
//Para obter segurança - oculte certos detalhes e mostre apenas os detalhes importantes de um objeto.