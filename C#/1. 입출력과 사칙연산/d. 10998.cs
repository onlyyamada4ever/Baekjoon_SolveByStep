// https://www.acmicpc.net/problem/10998
// 백준 단계별로 풀어보기 - 입출력과 사칙연산
// 4단계. 10998 A×B

// 시간 제한 : 1초
// 메모리 제한 : 256 MB
// 문제 : 두 정수 A와 B를 입력받은 다음, A×B를 출력하는 프로그램을 작성하시오.
// 입력 : 첫째 줄에 A와 B가 주어진다. (0 < A, B < 10)
// 출력 : 첫째 줄에 A×B를 출력한다.

using System;
namespace Baekjoon
{
    class BaekjoonSBS
    {
        static void Main(string[] args)
        {
            int[] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.WriteLine(num[0] * num[1]);
        }
    }
}
// https://elifsblog.tistory.com/4