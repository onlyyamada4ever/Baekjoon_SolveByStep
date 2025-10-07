// 문제 정보
// 1001번 A-B
// https://www.acmicpc.net/problem/1001
// 메모리 제한: 256 MB, 시간 제한: 1초 
// 두 정수 A와 B를 입력받은 다음, A-B를 출력하는 프로그램을 작성하시오.

using System;
namespace Baekjoon
{
    class Baekjoon1001
    {
        static void Main(string []args) 
        {
            string n = Console.ReadLine(); // 변수에 입력값 저장
            string[] num = n.Split(); // 공백을 기준으로 입력값 분리
            Console.WriteLine(int.Parse(num[0]) - int.Parse(num[1])); // 출력
            
        }
    }
}