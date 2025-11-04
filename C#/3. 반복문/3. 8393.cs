// 문제 정보
// 8393번 합
// https://www.acmicpc.net/problem/8393
// 메모리 제한: 128 MB, 시간 제한: 1초

// n이 주어졌을 때, 1부터 n까지 합을 구하는 프로그램을 작성하시오.

using System;
namespace Baekjoon
{
    class Baekjoon2884
    {
        static void Main(string []args) 
        {   
            int n = int.Parse(Console.ReadLine());
            int sum = n;
            
            for (int i = 1; i < n; i++)
            {
                sum += i;
            }
            Console.WriteLine($"{sum}");
        }
    }
}