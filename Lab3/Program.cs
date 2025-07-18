using System.Security.Cryptography.X509Certificates;

namespace Lab3;

class Program
{
    private static bool i;

    static int Main(string[] args)
    {
        //Problem 1
        for (int g = 1; g < 11; g++)
        {
            Console.WriteLine(g);
        }

        //Problem 2
        for (int f = 1; f < 22; f++)
        {
            if (f % 2 == 0)
            {
                Console.WriteLine(f);
            }
        }

        //Problem 3
        int v = 5;
        while (v > 0)
        {
            Console.WriteLine(v);
            v--;
        }

        //Problem 4
        int o = 10;
        do
        {
            Console.WriteLine(o);
            o += 10;
        }
        while (o < 1010);

        //Problem 5
        string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
        foreach (string i in seasons)
        {
            Console.WriteLine(i);
        }

        //Problem 6
        string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        Console.WriteLine("Enter a number 1 through 7");
        string number = Console.ReadLine();
        int dayNumber = int.Parse(number);
        Console.WriteLine("Day is" + days[dayNumber - 1]);

        

        //Problem 7
        string[] books = { "1984", "All Quiet on The Western Front", "Ham on Rye" };
        string[] authors = { "George Orwell", "Erich Maria Remarque", "Charles Bukowski" };
        for (int b = 0; b < books.Length; b++)
        {
            Console.WriteLine(books[b] + " by " + authors[b]);
        }

        //Problem 8
        int[] temp = { 10, 17, 5, 30, 90 };
        Array.Sort(temp);
        foreach (int i in temp)
        {
            Console.WriteLine(i);
        }
        int[] temp2 = { 10, 17, 5, 30, 90 };
        Console.WriteLine("Highest is" + temp2.Max());
        Console.WriteLine("Lowest is" + temp2.Min());

        //Problem 9
        int[] ar = { 5, 4, 3, 2, 1 };
        Array.Reverse(ar);
        for (int i = 0; i < ar.Length; i++)
        {
            Console.WriteLine(ar[i]);
        }
         


        



        

        
    }
}
