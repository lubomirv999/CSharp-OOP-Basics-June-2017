using System;

public class Startup
{
    public static void Main()
    {
        var input = Console.ReadLine();

        while (input != "End")
        {
            var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var foodTokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var quantity = int.Parse(foodTokens[1]);
            Food food;

            if (foodTokens[0] == "Vegetable")
            {
                food = new Vegetable(quantity);
            }
            else
            {
                food = new Meat(quantity);
            }

            var name = tokens[1];
            var weight = double.Parse(tokens[2]);
            var region = tokens[3];


            switch (tokens[0])
            {
                case "Mouse":
                    var mouse = new Mouse(name, weight, region);
                    ProcessEating(mouse, food);
                    break;
                case "Zebra":
                    var zebra = new Zebra(name, weight, region);
                    ProcessEating(zebra, food);
                    break;
                case "Tiger":
                    var tiger = new Tiger(name, weight, region);
                    ProcessEating(tiger, food);
                    break;
                default:
                    var cat = new Cat(name, weight, region, tokens[4]);
                    ProcessEating(cat, food);
                    break;
            }

            input = Console.ReadLine();
        }
    }

    private static void ProcessEating(Animal animal, Food food)
    {
        animal.MakeSound();
        animal.Eat(food);
        Console.WriteLine(animal.ToString());
    }
}