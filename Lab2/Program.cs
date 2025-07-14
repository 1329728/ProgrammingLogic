

class Program
{
    static void Main(string[] args)
    {
        //Part 1//

        int a = 10, b = 5, c = 15;
        Console.WriteLine(a > b);
        Console.WriteLine(a < c);
        Console.WriteLine(a > b && a > c);
        Console.WriteLine(a > b || a > c);

        //Part 2//

        bool isRaining = true;
        bool haveUmbrella = false;
        if (isRaining)
        {
            Console.WriteLine("Take an umbrella");
        }
        if (haveUmbrella)
        {
            Console.WriteLine("You're good to go!");
        }

        //Part 3//

        Console.WriteLine("Enter your age");
        int myAge = int.Parse(Console.ReadLine());
        if (myAge < 5)
        {
            Console.WriteLine("Ticket is free!");
        }
        if (myAge > 5 && myAge < 12)
        {
            Console.WriteLine("Child ticket: $5");
        }
        if (myAge >= 13 && myAge <= 64)
        {
            Console.WriteLine("Standard ticket: $10");
        }
        if (myAge >= 65)
        {
            Console.WriteLine("Senior ticket: $6");
        }

        //Part 4//
        Console.WriteLine("Enter a day of the week 1 through 7");
        int day = (int)Convert.ToInt64(Console.ReadLine());
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;

            case 2:
                Console.WriteLine("Tuesday");
                break;

            case 3:
                Console.WriteLine("Wednesday");
                break;

            case 4:
                Console.WriteLine("Thursday");
                break;

            case 5:
                Console.WriteLine("Friday");
                break;

            case 6:
                Console.WriteLine("Saturday");
                break;

            case 7:
                Console.WriteLine("Sunday");
                break;

            default:
                Console.WriteLine("Invalid day!");
                break;

        }

    }
}