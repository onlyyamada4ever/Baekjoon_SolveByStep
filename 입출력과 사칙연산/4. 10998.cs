// 문제 정보
// 10998번 A×B  
// https://www.acmicpc.net/problem/10998
// 메모리 제한: 256 MB, 시간 제한: 1초
// 두 정수 A와 B를 입력받은 다음, A×B를 출력하는 프로그램을 작성하시오.

using System;
namespace Baekjoon
{
    class Baekjoon10998
    {
        static void Main(string []args) 
        {
            string n = Console.ReadLine(); 
            string[] num = n.Split(); // 여기까지의 설명은 1000번 A+B 참조.
            Console.WriteLine(int.Parse(num[0]) * int.Parse(num[1]));
            // 곱셈은 덧셈, 뺄셈과 다르게 평소 자주 쓰는 x가 아닌 *가 쓰입니다.
            
        }
    }
}