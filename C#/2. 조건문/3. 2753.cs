// 문제 정보
// 2753번 윤년
// https://www.acmicpc.net/problem/2753
// 메모리 제한: 256 MB, 시간 제한: 1초

// 연도가 주어졌을 때, 윤년이면 1, 아니면 0을 출력하는 프로그램을 작성하시오.

using System;
namespace Baekjoon
{
    class Baekjoon2753
    {
        static void Main(string []args) 
        {   
         int year = int.Parse(Console.ReadLine());

         if (year % 4 == 0 && year % 100 != 0)
         {
             //4의 배수이면서 100의 배수가 아닌 경우 '0' 출력
             Console.WriteLine("1");
         }
        
         else if (year % 400 == 0)
         {
              // 400의 배수인 경우 '0' 출력
             Console.WriteLine("1");
         }
            
         else
         {
             // 모두 아닐 경우 '0' 출력
             Console.WriteLine("0");
         }
        }
    }
}