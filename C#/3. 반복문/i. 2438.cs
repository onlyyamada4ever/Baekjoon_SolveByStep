// https://www.acmicpc.net/problem/2438
// 백준 단계별로 풀어보기 - 조건문
// 9단계. 2438번 별 찍기 - 1

// 시간 제한 : 1초
// 메모리 제한 : 128 MB
// 문제 : 첫째 줄에는 별 1개, 둘째 줄에는 별 2개, N번째 줄에는 별 N개를 찍는 문제
// 입력 : 첫째 줄에 N(1 ≤ N ≤ 100)이 주어진다.
// 출력 : 첫째 줄부터 N번째 줄까지 차례대로 별을 출력한다 

using System;
namespace Baekjoon
{
    class Baekjoon2438
    {
        static void Main(string []args)
        {
            int Q = int.Parse(Console.ReadLine());
            for (int i = 0; i < Q; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}