// https://www.acmicpc.net/problem/1000
// 백준 단계별로 풀어보기 - 입출력과 사칙연산
// 2단계. 1000 A+B

// 시간 제한 : 2초
// 메모리 제한 : 128 MB
// 문제 : 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.
// 입력 : 첫째 줄에 A와 B가 주어진다. (0 < A, B < 10)
// 출력 : 첫째 줄에 A+B를 출력한다.

using System;
namespace Baekjoon{
    class BaekjoonSBS{
        static void Main(string[] args){
            string[] Num = Console.ReadLine().Split();
            // 입력값을 받아서 공백 기준으로 나눈 후 Num이라는 리스트에 저장
            Console.WriteLine(int.Parse(Num[0]) + int.Parse(Num[1]));
            // 리스트에 저장된 값을 정수형으로 바꾸어 덧셈
        }
    }
}
