using System;

// 역방향 별찍기 과제 제출
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
            for (int j = repeat; j >= i; j--)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }
}