/*a diferença entre pulbic e private é que a public qualquer classe do programa pode usar e a private só a classe que ela pertence, 
mas por padrão se vc não colocar nada ela sera private

Propriedades, se vc quiser acessar essas classe private fora da classe que ela esta vc pode utilizar, com o get e set;
o get vc vai pegar o valor da variavel private e o set vai alterar o valor dela*/

using System;

class Person
{
  public string Name //aqui ele esta pegando a variavel privated (get), gerada automaticamente,e alterando o valor dela atraves do set 
  { get; set; }
}

class Program
{
  static void Main(string[] args)
  {
    Person myObj = new Person();
    myObj.Name = "Liam";
    Console.WriteLine(myObj.Name);
  }
}