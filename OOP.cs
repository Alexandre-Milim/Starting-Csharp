using System;
					
class Car //aqui eu faço uma classe car, tem os objetos, modelo, cor e ano
{
  string model;
  string color;
  int year;

  static void Main(string[] args) //entrada do codigo
  {
    Car Ford = new Car(); //aqui eu pego a classe Car e crio a variavel Ford e declaro os objetos da class no Ford, ele recebe modelo, cor e ano
    Ford.model = "Mustang"; //aqui e pego a variavel Ford e passo valores para ela como "Mustang"
    Ford.color = "red";
    Ford.year = 1969;

    Car Opel = new Car();
    Opel.model = "Astra";
    Opel.color = "white";
    Opel.year = 2005;

    Console.WriteLine(Ford.model); // e aqui eu exibo os valores
    Console.WriteLine(Opel.model);
  }
}