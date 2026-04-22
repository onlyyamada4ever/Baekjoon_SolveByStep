using System;
namespace Baekjoon
{
    class Baekjoon11720
    {
        static void Main(string[] args)
        {
            int Q = int.Parse(Console.ReadLine());
            string nums = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < Q; i++)
            {
                sum = sum + (nums[i] - '0');
            }
            Console.WriteLine(sum);
        }
    }
}
