// 문제 정보
// 1330번 두 수 비교하기
// https://www.acmicpc.net/problem/1330
// 메모리 제한: 256 MB, 시간 제한: 1초

// 두 정수 A와 B가 주어졌을 때, A와 B를 비교하는 프로그램을 작성하시오.

using System;
namespace Baekjoon
{
    class Baekjoon1330
    {
        static void Main(string []args) 
        {   
         string inpt = Console.ReadLine();
         string[] num = inpt.Split();

         if(int.Parse(num[0]) < int.Parse(num[1]))
         {
             Console.WriteLine("<");
         }
         else if(int.Parse(num[0]) == int.Parse(num[1]))
         {
             Console.WriteLine("==");
         }
         else
         {
             Console.WriteLine(">");
         }
        }
    }
}