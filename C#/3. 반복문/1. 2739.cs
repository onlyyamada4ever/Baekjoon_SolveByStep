// 문제 정보
// 2739번 구구단
// https://www.acmicpc.net/problem/2739
// 메모리 제한: 256 MB, 시간 제한: 1초

// N을 입력받은 뒤, 구구단 N단을 출력하는 프로그램을 작성하시오.
// 출력 형식에 맞춰서 출력하면 된다.

// 출력 
// 출력형식과 같게 N*1부터 N*9까지 출력한다.

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