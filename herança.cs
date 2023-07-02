using System;

class Person  // classe base (pai)
{
    public string name;  // campo da classe Person (pai)
    
    public void Speak()  // método/função da classe Person (pai)
    {
        Console.WriteLine("eae, eu sou o " + name + ".");
    }
}


class Child : Person  // classe derivada (filho) pra herdar uma classse só usar o :
{
    public string school;  // campo da classe Child (filho)
}

class Program
{
    static void Main(string[] args)
    {
        Child son = new Child();
        son.name = "Milim";
        son.school = "sesi";
        son.Speak();
        Console.WriteLine("estudante do " + son.school + ".");
    }
}

//É útil para reutilização de código: reutilize campos e métodos de uma classe existente ao criar uma nova classe.