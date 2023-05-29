var max = 100;
var number = Random.Shared.Next(1, max);
var guessed = 0;
var attempt = 1;

Console.WriteLine($"Guess a number between 1 and {max - 1}");

while (guessed != number)
{
    Console.Write($"{attempt}> ");
    var str = Console.ReadLine();

    if (str == "")
    {
        Console.WriteLine("Exiting.");
        break;
    }

    if (!int.TryParse(str, out guessed))
    {
        Console.WriteLine("Please enter a number");
        continue;
    }

    if (guessed == number)
    {
        Console.WriteLine($"Right! It took you {attempt} attempts.");
        break;
    }

    attempt++;
    if (guessed < number)
        Console.WriteLine("Try higher");
    else
        Console.WriteLine("Try lower");
}
