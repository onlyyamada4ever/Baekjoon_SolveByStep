// 문제 정보
// 25304번 영수증
// https://www.acmicpc.net/problem/25304
// 메모리 제한: 1024 MB, 시간 제한: 1초

// 준원이는 저번 주에 살면서 처음으로 코스트코를 가 봤다. 정말 멋졌다. 
// 그런데, 몇 개 담지도 않았는데 수상하게 높은 금액이 나오는 것이다!
// 준원이는 영수증을 보면서 정확하게 계산된 것이 맞는지 확인해보려 한다.
// 영수증에 적힌, 
//  1. 구매한 각 물건의 가격과 개수
//  2. 구매한 물건들의 총 금액
// 을 보고, 구매한 물건의 가격과 개수로 계산한 총 금액이 영수증에 적힌 총 금액과 일치하는지 검사해보자.

// 입력
// 첫째 줄에는 영수증에 적힌 총 금액 X가 주어진다.
// 둘째 줄에는 영수증에 적힌 구매한 물건의 종류의 수 N이 주어진다.
// 이후 N개의 줄에는 각 물건의 가격 a와 개수 b가 공백을 사이에 두고 주어진다.

// 출력 
// 구매한 물건의 가격과 개수로 계산한 총 금액이 영수증에 적힌 총 금액과 일치하면 Yes를 출력한다.
// 일치하지 않는다면 No를 출력한다

using System;
namespace Baekjoon
{
    class Baekjoon25304
    {
        static void Main(string []args) 
        {   
            int Total = int.Parse(Console.ReadLine());
            int Quantity = int.Parse(Console.ReadLine());
            int price = 0;

            for (int i = 0; i < Quantity; i++)
            {
                string[] s = Console.ReadLine().Split();
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);

                price += a * b;

            }

            if(price == Total)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}