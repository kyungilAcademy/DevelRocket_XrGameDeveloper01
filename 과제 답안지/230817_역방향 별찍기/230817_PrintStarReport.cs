using System;

// 23-08-17 역방향 별찍기 과제 답안지
class Program
{
    static void Main(string[] args)
    {
        PrintStar(9);
    }

    static void PrintStar(int repeat)
    {
        for (int i = 1; i <= repeat; i++)
        {
            for (int j = repeat; j >= i; j--)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }
}