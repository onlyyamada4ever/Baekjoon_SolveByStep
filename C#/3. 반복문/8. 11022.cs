// 문제 정보
// 11022번 A+B - 8
// https://www.acmicpc.net/problem/11022
// 메모리 제한: 256 MB, 시간 제한: 1초

// 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.

// 입력
// 첫째 줄에 테스트 케이스의 개수 T가 주어진다.
// 각 테스트 케이스는 한 줄로 이루어져 있으며, 각 줄에 A와 B가 주어진다. (0 < A, B < 10)

// 출력
// 각 테스트 케이스마다 "Case #x: A + B = C" 형식으로 출력한다. x는 테스트 케이스 번호이고 1부터 시작하며, C는 A+B이다.

using System;
using System.Text;

class Program
{
    static void Main()
    {
        var sb = new StringBuilder();
        int t = int.Parse(Console.ReadLine());
        for (int i = 1; i <= t; i++)
        {
            var parts = Console.ReadLine().Split();
            int a = int.Parse(parts[0]);
            int b = int.Parse(parts[1]);
            sb.AppendLine($"Case #{i}: {a} + {b} = {a + b}");
        }
        Console.Write(sb.ToString());
    }
}