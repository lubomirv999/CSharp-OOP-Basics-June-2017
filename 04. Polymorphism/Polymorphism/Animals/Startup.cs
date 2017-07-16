using System;

public class Startup
{
    static void Main()
    {
        Animal cat = new Cat("Pesho", "Whiskas");
        Animal dog = new Dog("Gosho", "Meat");

        Console.WriteLine(cat.ExplainMyself());
        Console.WriteLine(dog.ExplainMyself());
    }
}