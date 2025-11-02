// 문제 정보
// 9498번 시험 성적
// https://www.acmicpc.net/problem/9498
// 메모리 제한: 256 MB, 시간 제한: 1초

// 시험 점수를 입력받아 90 ~ 100점은 A, 80 ~ 89점은 B, 70 ~ 79점은 C, 60 ~ 69점은 D, 나머지 점수는 F를 출력하는 프로그램을 작성하시오.

using System;
namespace Baekjoon
{
    class Baekjoon9498
    {
        static void Main(string []args) 
        {   
         int grade = int.Parse(Console.ReadLine());
            
         if (grade >= 90)
         {
             Console.WriteLine("A");
         }
         else if (grade >= 80)
         {
             Console.WriteLine("B");
         }
         else if (grade >= 70)
         {
             Console.WriteLine("C");
         }
         else if (grade >= 60)
         {
             Console.WriteLine("D");
         }
         else
         {
             Console.WriteLine("F");
         }
        }
    }
}