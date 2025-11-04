// 문제 정보
// 2480번 주사위 세개
// https://www.acmicpc.net/problem/2480
// 메모리 제한: 256 MB, 시간 제한: 1초

// 1에서부터 6까지의 눈을 가진 3개의 주사위를 던져서 다음과 같은 규칙에 따라 상금을 받는 게임이 있다.
//
//     1. 같은 눈이 3개가 나오면 10,000원+(같은 눈)×1,000원의 상금을 받게 된다.
//     2. 같은 눈이 2개만 나오는 경우에는 1,000원+(같은 눈)×100원의 상금을 받게 된다.
//     3. 두 다른 눈이 나오는 경우에는 (그 중 가장 큰 눈)×100원의 상금을 받게 된다.
//
// 예를 들어, 3개의 눈 3, 3, 6이 주어지면 상금은 1,000+3×100으로 계산되어 1,300원을 받게 된다.
// 또 3개의 눈이 2, 2, 2로 주어지면 10,000+2×1,000 으로 계산되어 12,000원을 받게 된다.
//  3개의 눈이 6, 2, 5로 주어지면 그중 가장 큰 값이 6이므로 6×100으로 계산되어 600원을 상금으로 받게 된다.
// 3개 주사위의 나온 눈이 주어질 때, 상금을 계산하는 프로그램을 작성 하시오.

using System;

namespace Baekjoon
{
    class Baekjoon2480
    {
        static void Main(string[] args)
        {
            string[] inpt = Console.ReadLine().Split();
            int d1 = int.Parse(inpt[0]);
            int d2 = int.Parse(inpt[1]);
            int d3 = int.Parse(inpt[2]);

            if (d1 == d2 && d2 == d3) // 세 주사위가 모두 같을 때
            {
                Console.WriteLine(10000 + d1 * 1000);
            }       
            else if (d1 == d2 || d1 == d3) // 둘만 같을 때
            {
                Console.WriteLine(1000 + d1 * 100);
            }
            else if (d2 == d3) // 둘만 같을 때
            {
                Console.WriteLine(1000 + d2 * 100); 
            }
            else
            {
                int biggest = Math.Max(d1, Math.Max(d2, d3));
                // Math.Max를 활용하여 가장 큰 수 찾기
                Console.WriteLine(biggest * 100);
            }
        }
    }
}