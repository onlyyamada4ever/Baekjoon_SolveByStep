// https://www.acmicpc.net/problem/10951
// 백준 단계별로 풀어보기 - 조건문
// 12단계. 10952번 A+B - 4

// 시간 제한 : 1초
// 메모리 제한 : 256 MB
// 문제 : 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
// 입력 : 입력은 여러 개의 테스트 케이스로 이루어져 있다. 각 테스트 케이스는 한 줄로 이루어져 있으며,
//        각 줄에 A와 B가 주어진다. (0 < A, B < 10)
// 출력 : 각 테스트 케이스마다 A+B를 출력한다.

using System;
namespace Baekjoon
{
    class Baekjoon10951
    {
        static void Main(string[] args)
        {
           while (true)
              {
                string s = Console.ReadLine();
                if (s == null) break;
                string[] n = s.Split();
                int a = int.Parse(n[0]);
                int b = int.Parse(n[1]);
                Console.WriteLine(a + b);
            }
        }
    }
}