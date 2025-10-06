// 문제 정보
// 100869번 사칙연산
// https://www.acmicpc.net/problem/100869
// 메모리 제한: 256 MB, 시간 제한: 1초
// 두 자연수 A와 B가 주어진다. 이때, A+B, A-B, A*B, A/B(몫), A%B(나머지)를 출력하는 프로그램을 작성하시오. 

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