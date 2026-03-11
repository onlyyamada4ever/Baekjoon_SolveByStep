// https://www.acmicpc.net/problem/2588
// 백준 단계별로 풀어보기 - 입출력과 사칙연산
// 10단계. 2588 곱셈

// 시간 제한 : 1초
// 메모리 제한 : 128 MB
// 문제 : (세 자리 수) × (세 자리 수)는 다음과 같은 과정을 통하여 이루어진다.
//            472 ... (1)
//          × 385 ... (2) 
//        ---------
//           2360 ... (3)
//          3776  ... (4)
//         1416   ... (5)
//        ---------
//         181720 ... (6)

//        (1)과 (2)위치에 들어갈 세 자리 자연수가 주어질 때 
//        (3), (4), (5), (6)위치에 들어갈 값을 구하는 프로그램을 작성하시오.

// 입력 : 첫째 줄에 (1)의 위치에 들어갈 세 자리 자연수가, 둘째 줄에 (2)의 위치에 들어갈 세자리 자연수가 주어진다.
// 출력 : 첫째 줄부터 넷째 줄까지 차례대로 (3), (4), (5), (6)에 들어갈 값을 출력한다.

using System;
namespace Baekjoon
{
    class Baekjoon2588
    {
        static void Main(string []args) 
        {
            string A = Console.ReadLine(); // 입력값을 "A"에 저장
            string B = Console.ReadLine(); // 입력값을 "B"에 저장
            char[] num = B.ToCharArray(); // "B" 를 문자 하나하나로 나눠 "num"에 저장
            int X = int.Parse(A); // "A"를 정수형으로 변환해 "X"에 저장
            int Y = int.Parse(B); // "B"를 정수형으로 변환해 "Y"에 저장
            
            Console.WriteLine(X * int.Parse(num[2].ToString())); // 1의 자리 계산
            Console.WriteLine(X * int.Parse(num[1].ToString())); // 10의 자리 계산
            Console.WriteLine(X * int.Parse(num[0].ToString())); // 100의 자리 계산
            Console.WriteLine(X * Y); // 전체 계산 결과 출력
        }
    }
}
// 풀이: 