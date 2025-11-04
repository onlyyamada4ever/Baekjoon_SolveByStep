// 문제 정보
// 11382번 꼬마 정민
// https://www.acmicpc.net/problem/11382
// 메모리 제한: 256 MB, 시간 제한: 1초

// 꼬마 정민이는 이제 A + B 정도는 쉽게 계산할 수 있다. 이제 A + B + C를 계산할 차례이다!

using System;
namespace Baekjoon
{
    class Baekjoon11382
    {
        static void Main(string []args) 
        {
            string n = Console.ReadLine();
            string[] num = n.Split();
            
            Console.WriteLine(long.Parse(num[0]) + long.Parse(num[1]) + long.Parse(num[2]));
        }
    }
}