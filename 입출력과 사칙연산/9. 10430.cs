// 문제 정보
// 10430번 나머지
// https://www.acmicpc.net/problem/10430
// 메모리 제한: 256 MB, 시간 제한: 1초
// (A+B)%C는 ((A%C) + (B%C))%C 와 같을까?
// (A×B)%C는 ((A%C) × (B%C))%C 와 같을까?
// 세 수 A, B, C가 주어졌을 때, 위의 네 가지 값을 구하는 프로그램을 작성하시오.

using System;
namespace Baekjoon
{
    class Baekjoon1000 
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