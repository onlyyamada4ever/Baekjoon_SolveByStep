// https://www.acmicpc.net/problem/2439
// 백준 단계별로 풀어보기 - 조건문
// 10단계. 2438번 별 찍기 - 2

// 시간 제한 : 1초
// 메모리 제한 : 128 MB
// 문제 : 첫째 줄에는 별 1개, 둘째 줄에는 별 2개, N번째 줄에는 별 N개를 찍는 문제
//       하지만, 오른쪽을 기준으로 정렬한 별(예제 참고)을 출력하시오.
// 입력 : 첫째 줄에 N(1 ≤ N ≤ 100)이 주어진다.
// 출력 : 첫째 줄부터 N번째 줄까지 차례대로 별을 출력한다 

using System;
namespace Baekjoon
{
    class Baekjoon2439
    {
        static void Main(string []args)
        {
            int Q = int.Parse(Console.ReadLine());
            for (int i = 0; i < Q; i++)
            {
                for (int j = 0; j < Q-i-1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i+1; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}