using System;

public class Startup
{
    public static void Main(string[] args)
    {
        var firstDate = Console.ReadLine();
        var secondDate = Console.ReadLine();

        var diff = DateModifier.CalculateDiff(firstDate, secondDate);
        Console.WriteLine(diff);
    }
}