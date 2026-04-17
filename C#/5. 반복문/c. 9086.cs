using System;
namespace Baekjoon
{
    class Baekjoon9086
    {
        static void Main(string[] args)
        {
            int Q = int.Parse(Console.ReadLine());
            for (int i = 1; i <= Q; i++)
            {
                string Temp = Console.ReadLine();
                Console.WriteLine($"{Temp[0]}{Temp[Temp.Length-1]}");
            }
        }
    }
}
