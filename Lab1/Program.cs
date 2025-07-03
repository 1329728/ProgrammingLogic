
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

class Program
{
    static int Main(string[] args)
    {
        // Step 1
        /*Kyle Kostansek IT 1050 Lab 1
        Step 2 */
        Console.WriteLine(KyleKostansek IT1050);

        //Step 3//
        int myNum = 23;
        Console.WriteLine("My favorite number is " + myNum + "");
        string myName = "HTML";
        Console.WriteLine("My favorite programming language is " + myName + "");
        double MyDoublenum = 0;
        Console.WriteLine("I have written " + MyDoublenum + "");
        bool myBool = true;
        Console.WriteLine("My programming experience is " + myBool + "");

        //Step 4//
        const string myName2 = "Tri-C";
        Console.WriteLine("My school name is " + myName2 + "");

        //Step 5//
        int myInt = (int)9.78;
        double doubleValue = 4.89;
        bool myBool2 = true;
        Console.WriteLine(Convert.ToString(myInt));
        Console.WriteLine(Convert.ToString(myBool2));
        Console.WriteLine("double:" + doubleValue);

        //Step 6//
        Console.WriteLine("Enter Name");
        string Name = Console.ReadLine();
        Console.WriteLine("Enter Age");
        string Age = Console.ReadLine();
        Convert.ToInt32();
        Console.WriteLine("Your name and age are: " + Name + Age);

        //Step 7//
        int num1 = 5;
        int num2 = 10;
        Console.WriteLine(num1 + 10);
        Console.WriteLine(num2 + 10);
        Console.WriteLine(num1 - 2);
        Console.WriteLine(num2 - 2);
        Console.WriteLine(num1 * 3);
        Console.WriteLine(num2 * 3);
        Console.WriteLine(num1 / 2);
        Console.WriteLine(num2 / 2);
        Console.WriteLine(num1 % 2);
        Console.WriteLine(num2 % 2);

        //Step 8//
        float dec = 1.123456789F;
        Console.WriteLine(dec);
        double dec2 = 1.123456789D;
        Console.WriteLine(dec2);

        //Step 9//
        int num3 = 10;
        Console.WriteLine(num3++);
        Console.WriteLine(num3--);




        

        











    }   
}