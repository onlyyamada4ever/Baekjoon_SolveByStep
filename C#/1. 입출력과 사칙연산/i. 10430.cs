// https://www.acmicpc.net/problem/10430
// 백준 단계별로 풀어보기 - 입출력과 사칙연산
// 9단계. 10430 나머지

// 시간 제한 : 1초
// 메모리 제한 : 256 MB
// 문제 : (A+B)%C는 ((A%C) + (B%C))%C 와 같을까?
//       (A×B)%C는 ((A%C) × (B%C))%C 와 같을까?
//       세 수 A, B, C가 주어졌을 때, 위의 네 가지 값을 구하는 프로그램을 작성하시오.
// 입력 : 첫째 줄에 A, B, C가 순서대로 주어진다. (2 ≤ A, B, C ≤ 10000)
// 출력 : 첫째 줄에 (A+B)%C, 둘째 줄에 ((A%C) + (B%C))%C, 셋째 줄에 (A×B)%C,
//       넷째 줄에 ((A%C) × (B%C))%C를 출력한다.

using System;
namespace Baekjoon
{
    class Baekjoon10430
    {
        static void Main(string []args) 
        {
            string n = Console.ReadLine();
            string[] num = n.Split();
            int A = int.Parse(num[0]);
            int B = int.Parse(num[1]);
            int C = int.Parse(num[2]);
                
            Console.WriteLine((A + B)% C);
            Console.WriteLine(((A % C)+(B % C))% C); 
            Console.WriteLine((A * B)% C); 
            Console.WriteLine(((A % C)*(B % C))% C);

        }
    }
}
// 풀이: https://elifsblog.tistory.com/11