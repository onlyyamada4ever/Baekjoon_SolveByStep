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