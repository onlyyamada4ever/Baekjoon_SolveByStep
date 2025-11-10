// 문제 정보
// 10951번 A+B - 4
// https://www.acmicpc.net/problem/10951
// 메모리 제한: 256 MB, 시간 제한: 1초

// 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.

// 입력
// 입력은 여러 개의 테스트 케이스로 이루어져 있다.
// 각 테스트 케이스는 한 줄로 이루어져 있으며, 각 줄에 A와 B가 주어진다. (0 < A, B < 10)

// 출력
// 각 테스트 케이스마다 A+B를 출력한다.

// 특수조건 : 입력이 끝날때까지 출력한다. (EOF에 대해 알아보세요.)

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
                // 사실 스트림리더의 EOF를 사용해야하는것 같지만.. 
                // 이래도 작동하니 조아쓰!!
                string[] n = s.Split();
                int a = int.Parse(n[0]);
                int b = int.Parse(n[1]);
                Console.WriteLine(a + b);
            }
        }
    }
}