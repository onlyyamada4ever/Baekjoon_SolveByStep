using System;
using System.Linq;

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
