using System;

class Program
{
    static void Main(string[] args)
    {
        PrintStar(10);
    }

    static void PrintStar(int repeat)
    {
        for (int i = 1; i <= repeat; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }
}