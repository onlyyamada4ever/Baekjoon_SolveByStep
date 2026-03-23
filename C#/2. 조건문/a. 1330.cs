// https://www.acmicpc.net/problem/1330
// 백준 단계별로 풀어보기 - 조건문
// 1단계. 1330 두 수 비교하기

// 시간 제한 : 1초
// 메모리 제한 : 512 MB
// 문제 : 두 정수 A와 B가 주어졌을 때, A와 B를 비교하는 프로그램을 작성하시오.
// 입력 : 첫째 줄에 A와 B가 주어진다. A와 B는 공백 한 칸으로 구분되어져 있다.
// 출력 : 첫째 줄에 다음 세 가지 중 하나를 출력한다.
// · A가 B보다 큰 경우에는 '>'를 출력한다.
// · A가 B보다 작은 경우에는 '<'를 출력한다.
// · A와 B가 같은 경우에는 '=='를 출력한다.

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
// 풀이: