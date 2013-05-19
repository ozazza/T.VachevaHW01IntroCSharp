using System;

class Numbers1And101And1001
{
    static void Main()
    {
        //Console.WriteLine(1);
        //Console.WriteLine(101);
        //Console.WriteLine(1001);

        int x = 1;
        int y = 0;

        int sumFirst = x + y;
        string sumSecond = x.ToString() + y + x;
        string sumThirth = x.ToString() + y + y + x;

        Console.WriteLine(sumFirst);
        Console.WriteLine(sumSecond);
        Console.WriteLine(sumThirth);
    }
}