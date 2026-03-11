// https://www.acmicpc.net/problem/18108
// 백준 단계별로 풀어보기 - 입출력과 사칙연산
// 8단계. 18108 1998년생인 내가 태국에서는 2541년생?!

// 시간 제한 : 1초 (추가 시간 없음)
// 메모리 제한 : 1024 MB
// 문제 : ICPC Bangkok Regional에 참가하기 위해 수완나품 국제공항에 막 도착한 팀 레드시프트 일행은 눈을 믿을 수 없었다.
//       공항의 대형 스크린에 올해가 2562년이라고 적혀 있던 것이었다. 불교 국가인 태국은 불멸기원(佛滅紀元),
//       즉 석가모니가 열반한 해를 기준으로 연도를 세는 불기를 사용한다. 반면, 우리나라는 서기 연도를 사용하고 있다.
//       불기 연도가 주어질 때 이를 서기 연도로 바꿔 주는 프로그램을 작성하시오.
// 입력 : 서기 연도를 알아보고 싶은 불기 연도 y가 주어진다. (1000 ≤ y ≤ 3000)
// 출력 : 불기 연도를 서기 연도로 변환한 결과를 출력한다.

using System;
namespace Baekjoon
{
    class Baekjoon18108
    {
        static void Main(string []args) 
        {
            Console.WriteLine(int.Parse(Console.ReadLine()) - 543); // 입력값을 정수로 변환, 입력값 -543 출력
                 
        }
    }
}
// 풀이: https://elifsblog.tistory.com/9