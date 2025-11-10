// 문제 정보
// 2438번 별 찍기 - 1
// https://www.acmicpc.net/problem/9438
// 메모리 제한: 128 MB, 시간 제한: 1초

// 첫째 줄에는 별 1개, 둘째 줄에는 별 2개, N번째 줄에는 별 N개를 찍는 문제

using System;

class Program
{
    static void Main(string[] args)
    {
         int inpt = int.Parse(Console.ReadLine());
            for (int i = 0; i < inpt; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
    }
}