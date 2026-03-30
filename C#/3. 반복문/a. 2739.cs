// https://www.acmicpc.net/problem/2739
// 백준 단계별로 풀어보기 - 조건문
// 1단계. 2739 구구단

// 시간 제한 : 1초
// 메모리 제한 : 128 MB
// 문제 : N을 입력받은 뒤, 구구단 N단을 출력하는 프로그램을 작성하시오. 출력 형식에 맞춰서 출력하면 된다.
// 입력 : 첫째 줄에 N이 주어진다. N은 1보다 크거나 같고, 9보다 작거나 같다.
// 출력 :출력형식과 같게 N*1부터 N*9까지 출력한다.

using System;
namespace Baekjoon
{
    class Baekjoon2739
    {
        static void Main(string []args) 
        {   
            int num = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"{num} * {i} = "+ num*i);
            }

        }
    }
}
// 풀이: 