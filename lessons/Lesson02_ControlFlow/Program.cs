using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Lesson 2 – Control Flow");
        Console.WriteLine("[1] Odd/Even + Countdown");
        Console.WriteLine("[2] CodexBuzz (1–50)");
        Console.Write("Choose: ");
        var choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                OddEvenCountdown();
                break;
            case "2":
                CodexBuzz();
                break;
            default:
                Console.WriteLine("Unknown option.");
                break;
        }
    }

    static void OddEvenCountdown()
    {
        Console.WriteLine("Give me a number between 1 and 100.");
        if (!int.TryParse(Console.ReadLine(), out int num))
        {
            Console.WriteLine("That wasn’t a valid number.");
            return;
        }

        if (num % 2 == 0)
            Console.WriteLine("Even");
        else
            Console.WriteLine("Odd");

        for (int i = num; i >= 0; i--)
            Console.WriteLine(i);
    }

    static void CodexBuzz()
    {
        for (int n = 1; n <= 50; n++)
        {
            bool by3 = (n % 3 == 0);
            bool by5 = (n % 5 == 0);

            if (by3 && by5) Console.WriteLine("CodexBuzz");
            else if (by3)   Console.WriteLine("Codex");
            else if (by5)   Console.WriteLine("Buzz");
            else            Console.WriteLine(n);
        }
    }
}
