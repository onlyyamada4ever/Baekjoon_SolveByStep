// https://www.acmicpc.net/problem/10869
// 백준 단계별로 풀어보기 - 입출력과 사칙연산
// 6단계. 10869 사칙연산

// 시간 제한 : 1초
// 메모리 제한 : 256 MB
// 문제 : 두 자연수 A와 B가 주어진다. 이때, A+B, A-B, A*B, A/B(몫), A%B(나머지)를 출력하는 프로그램을 작성하시오. 
// 입력 : 두 자연수 A와 B가 주어진다. (1 ≤ A, B ≤ 10,000)
// 출력 : 첫째 줄에 A+B, 둘째 줄에 A-B, 셋째 줄에 A*B, 넷째 줄에 A/B, 다섯째 줄에 A%B를 출력한다.

using System;
namespace Baekjoon
{
    class Baekjoon10869
    {
        static void Main(string []args) 
        {
            string n = Console.ReadLine();
            string[] num = n.Split();
            Console.WriteLine(int.Parse(num[0]) + int.Parse(num[1]));
            Console.WriteLine(int.Parse(num[0]) - int.Parse(num[1]));
            Console.WriteLine(int.Parse(num[0]) * int.Parse(num[1]));
            Console.WriteLine(int.Parse(num[0]) / int.Parse(num[1]));
            Console.WriteLine(int.Parse(num[0]) % int.Parse(num[1]));
            
        }
    }
}
// 풀이: https://elifsblog.tistory.com/6