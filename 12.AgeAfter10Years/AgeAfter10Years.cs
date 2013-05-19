using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Enter the number of years that you are now and press Enter:");
        string age = Console.ReadLine();
        int intAge = int.Parse(age);
        Console.WriteLine("After 10 years, you will be: {0}, now u are: {1}", (intAge+10), age);
        //Console.WriteLine(intAge + 10);
    }
}