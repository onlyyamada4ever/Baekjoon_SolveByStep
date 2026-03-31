// https://www.acmicpc.net/problem/11022
// 백준 단계별로 풀어보기 - 조건문
// 8단계. 11022번 A+B - 8

// 시간 제한 : 1초
// 메모리 제한 : 256 MB
// 문제 : 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
// 입력 : 첫째 줄에 테스트 케이스의 개수 T가 주어진다. 각 테스트 케이스는 한 줄로 이루어져 있으며, 각 줄에 A와 B가 주어진다. (0 < A, B < 10)
// 출력:  각 테스트 케이스마다 "Case #x: A + B = C" 형식으로 출력한다. x는 테스트 케이스 번호이고 1부터 시작하며, C는 A+B이다.

using System;
namespace Baekjoon
{
    class Baekjoon11022
    {
        static void Main(string []args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                string[] num = Console.ReadLine().Split();
                string math = $" {num[0]} + {num[1]} = " + (int.Parse(num[0]) + int.Parse(num[1]));
                Console.WriteLine($"Case #{i+1}:{math}");
            }
        }
    }
}