// https://www.acmicpc.net/problem/10807
// 백준 단계별로 풀어보기 - 반복문
// 1단계. 10807 개수 세기

// 시간 제한 : 1초
// 메모리 제한 : 256 MB
// 문제 : 총 N개의 정수가 주어졌을 때, 정수 v가 몇 개인지 구하는 프로그램을 작성하시오.
// 입력 : 첫째 줄에 정수의 개수 N(1 ≤ N ≤ 100)이 주어진다. 둘째 줄에는 정수가 공백으로 구분되어져있다. 셋째 줄에는 찾으려고 하는 정수 v가 주어진다.
//       입력으로 주어지는 정수와 v는 -100보다 크거나 같으며, 100보다 작거나 같다.
// 출력 : 첫째 줄에 입력으로 주어진 N개의 정수 중에 v가 몇 개인지 출력한다.

using System;
using System.Linq;
namespace Baekjoon
{
    class Baekjoon10807
    {
        static void Main()
        {
            int TotalQ = int.Parse(Console.ReadLine());
            // 정수값 갯수 입력
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            // 정수값 입력받은 후 정수로 변환, Array에 저장
            int V = int.Parse(Console.ReadLine());
            // 지정받은 정수값 V를 입력받아 저장
            int vCount = 0;

            for (int i = 0; i < TotalQ; i++)
            {
                if (arr[i] == V) vCount++;
                // Array에 있는 정수가 V와 일치한다면 vCount 1 추가
            }
            Console.WriteLine(vCount);
            // vCount(지정받은 값 속 V 갯수) 출력
        }
    }
}