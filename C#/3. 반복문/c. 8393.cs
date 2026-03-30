// https://www.acmicpc.net/problem/8393
// 백준 단계별로 풀어보기 - 조건문
// 3단계. 8393 합

// 시간 제한 : 1초
// 메모리 제한 : 128 MB
// 문제 : n이 주어졌을 때, 1부터 n까지 합을 구하는 프로그램을 작성하시오.
// 입력 : 첫째 줄에 n (1 ≤ n ≤ 10,000)이 주어진다.
// 출력 : 1부터 n까지 합을 출력한다.

using System;
namespace Baekjoon
{
    class Baekjoon8393
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