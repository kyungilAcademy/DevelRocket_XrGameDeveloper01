using System;

// 정방향 별찍기 과제 제출
class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 7; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }
}