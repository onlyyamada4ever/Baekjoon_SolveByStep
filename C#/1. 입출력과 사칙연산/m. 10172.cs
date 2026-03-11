// https://www.acmicpc.net/problem/10172
// 백준 단계별로 풀어보기 - 입출력과 사칙연산
// 13단계. 10172 개

// 시간 제한 : 1초
// 메모리 제한 : 256 MB
// 문제 : 아래 예제와 같이 개를 출력하시오.
// 입력 : 없음
// 출력 : 개를 출력한다.
// 예제 출력
// |\_/|
// |q p|   /}
// ( 0 )"""\
// |"^"`    |
// ||_/=\\__|

using System;
namespace Baekjoon
{
    class Baekjoon10172
    {
        static void Main(string []args) 
        {   
            // " 앞에 \를 붙이면 "를 문자열로 출력 가능.
            Console.WriteLine("|\\_/|");
            Console.WriteLine("|q p|   /}");
            Console.WriteLine("( 0 )\"\"\"\\");
            Console.WriteLine("|\"^\"`    |");
            Console.WriteLine("||_/=\\\\__|");
        }
    }
}
// 풀이: 