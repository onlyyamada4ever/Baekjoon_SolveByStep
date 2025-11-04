// 문제 정보
// 11021번 A+B - 7
// https://www.acmicpc.net/problem/11021
// 메모리 제한: 256 MB, 시간 제한: 1초

// 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.

// 출력
// 각 테스트 케이스마다 "Case #x: "를 출력한 다음, A+B를 출력한다. 테스트 케이스 번호는 1부터 시작한다.

using System;
using System.Text;

namespace for문4
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder answer = new StringBuilder();
            int t = int.Parse(Console.ReadLine());
            
            // 더하기 때 사용할 int를 배열로 생성함
            int[] a = new int[t];
            int[] b = new int[t];

            for (int i = 0; i < t; i++)
            {
                // 숫자를 입력받고 공백을 기준으로 나눠 담을 수 있게 문자열 배열을 선언한다.
                string[] s = Console.ReadLine().Split();
                // 입력받은 문자를 int형으로 변환해서 저장한다.
                a[i] = int.Parse(s[0]);
                b[i] = int.Parse(s[1]);
                
                // 각 숫자를 더한뒤 문자열로 변환하고 answer에 집어 넣음
                answer.AppendLine($"Case #{i+1}: "+(a[i] + b[i]).ToString());
            }
            // 출력
            Console.WriteLine(answer.ToString());
        }
    }
}