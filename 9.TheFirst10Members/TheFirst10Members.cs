using System;

class TheFirst10Members
{
    static void Main()
    {
        //Console.WriteLine(2);
        //Console.WriteLine(-3);
        //Console.WriteLine(4);
        //Console.WriteLine(-5);
        //Console.WriteLine(6);
        //Console.WriteLine(-7);
        //Console.WriteLine(8);
        //Console.WriteLine(-9);
        //Console.WriteLine(10);

        for (int x = 2; x <= 11; x++)
        {
            Console.WriteLine((x % 2 == 0) ? x : -x);
            if (x % 2 == 0)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(-x);
            }
        }
    }
}
