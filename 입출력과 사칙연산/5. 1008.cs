// 문제 정보
// 1008번 A/B               
// https://www.acmicpc.net/problem/1008
// 메모리 제한: 256 MB, 시간 제한: 1초
// 두 정수 A와 B를 입력받은 다음, A/B를 출력하는 프로그램을 작성하시오.

using System;
namespace Baekjoon
{
    class Baekjoon1008
    {
        static void Main(string []args) 
        {
            string n = Console.ReadLine();
            string[] num = n.Split();
            Console.WriteLine(double.Parse(num[0]) / double.Parse(num[1]));
            // 구조는 1000, 1001, 10998번과 동일하지만,10^-9 이하의 오차로 나타내야 하기 때문에
            // int 대신 double로 사용.
            
        }
    }
}