// 문제 정보
// 1000번 A+B  
// https://www.acmicpc.net/problem/1000 
// 메모리 제한: 256 MB, 시간 제한: 1초  

// 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.

using System;
namespace Baekjoon
{
    class Baekjoon1000 
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            // Console.ReadLine() 메서드를 이용하여 콘솔에서 입력받은 내용을 문자열로 저장.
            string[] num = n.Split(); // 공백()을 기준으로 입력값 분리
            // 문자열을 분리했으나 자료형은 아직 문자열. 정수형 혹은 char로 바꿔줘야 연산 후 출력이 가능함

            Console.WriteLine(int.Parse(num[0]) + int.Parse(num[1]));
            // int.Parse() 메서드를 이용하여 문자열을 정수형으로 변환후 출력

        }
    }
}