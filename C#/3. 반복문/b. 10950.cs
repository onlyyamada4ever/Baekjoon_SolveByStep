// https://www.acmicpc.net/problem/10950
// 백준 단계별로 풀어보기 - 조건문
// 2단계. 10950 A+B - 3

// 시간 제한 : 1초
// 메모리 제한 : 256 MB
// 문제 : 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
// 입력 : 첫째 줄에 테스트 케이스의 개수 T가 주어진다.
//       각 테스트 케이스는 한 줄로 이루어져 있으며, 각 줄에 A와 B가 주어진다. (0 < A, B < 10)
// 출력 : 각 테스트 케이스마다 A+B를 출력한다.

using System;
namespace Baekjoon
{
    class Baekjoon10950
    {
        static void Main(string[] args)
        {   
            int casecount = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < casecount; i++)
            {
                string[] num = Console.ReadLine().Split();
                Console.WriteLine(int.Parse(num[0]) + int.Parse(num[1]));
            }
        }
    }
}
// 풀이: