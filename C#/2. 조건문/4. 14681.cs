// 문제 정보
// 14681번 사분면 고르기
// https://www.acmicpc.net/problem/14681
// 메모리 제한: 256 MB, 시간 제한: 1초

// 흔한 수학 문제 중 하나는 주어진 점이 어느 사분면에 속하는지 알아내는 것이다.
// 사분면은 아래 그림처럼 1부터 4까지 번호를 갖는다. "Quadrant n"은 "제n사분면"이라는 뜻이다.
//                y
//  Quadrant 2    |  Quadrant 1
//                |
//                |
//  B (-12, 5) o  |   o A (12,5)
//  ---------------------------- x
//  C (-12,-5) o  |   o D (12,-5)               
//                |
//                |
//   Quadrant 3   |  Quadrant 4
//                |
// 예를 들어, 좌표가 (12, 5)인 점 A는 x좌표와 y좌표가 모두 양수이므로 제1사분면에 속한다.
// 점 B는 x좌표가 음수이고 y좌표가 양수이므로 제2사분면에 속한다.
// 점의 좌표를 입력받아 그 점이 어느 사분면에 속하는지 알아내는 프로그램을 작성하시오. 
// 단, x좌표와 y좌표는 모두 양수나 음수라고 가정한다.

using System;
namespace Baekjoon
{
    class Baekjoon14681
    {
        static void Main(string []args) 
        {  
            int CoordX = int.Parse(Console.ReadLine());
            int CoordY = int.Parse(Console.ReadLine());
            
            if (CoordX > 0 && CoordY > 0)
            {
                // x가 양수이면서 y도 양수일 경우 1 출력
                Console.WriteLine("1");
            }
            else if (CoordX < 0 && CoordY > 0)
            {
                // x가 음수이면서 y는 양수일경우 2 출력
                Console.WriteLine("2");
            }
            else if (CoordX < 0 && CoordY < 0)
            {
                // x가 음수이면서 y도 음수일경우 3 출력
                Console.WriteLine("3");
            }
            else
            {
                // 위 조건 중 아무것도 맞지 않으면 4 출력
                Console.WriteLine("4");
            }
        }
    }
}