using System;

namespace MyApplication
{
    class Car //aqui eu fiz uma classe carro
    {
        public string model; //aqui eu fiz uma public passando como public, pq se tiver como private a main não consegue pegar e da B.O, essas publics são objetos 
        public string color;
        public int year;
		public string velocity;

        public Car(string model, string color, int year, string velocity)// aqui ele passa os valores que tem dentro da classe car
        {
            this.model = model; // o this serve pra fazer uma referencia ao obejto da classe, o que esta depois do = que vai receber os objetos da classe
            this.color = color;
            this.year = year;
			this.velocity = velocity;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "Red", 1969, "velozzzz"); //aqui eu passei os valores dos objetos
            Car Opel = new Car("Astra", "White", 2005, "velozzzzaasasssaas");

            Console.WriteLine(Ford.velocity);
            Console.WriteLine(Opel.velocity);
        }
    }
}
