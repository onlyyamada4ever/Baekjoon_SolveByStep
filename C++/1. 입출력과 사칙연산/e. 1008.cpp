// https://www.acmicpc.net/problem/1008
// 백준 단계별로 풀어보기 - 입출력과 사칙연산
// 5단계. 1008 A/B

// 시간 제한 : 2초
// 메모리 제한 : 128 MB
// 문제 : 두 정수 A와 B를 입력받은 다음, A/B를 출력하는 프로그램을 작성하시오.
// 입력 : 첫째 줄에 A와 B가 주어진다. (0 < A, B < 10)
// 출력 : 첫째 줄에 A/B를 출력한다. 실제 정답과 출력값의 절대오차 또는 상대오차가 10^-9 이하이면 정답이다.
// --------------------------------
#include <iostream>

int main() {
    double A; double B;
    std::cin >> A;
    std::cin >> B;
    
    std::cout.precision(16); // 출력 자릿수 고정(전체)
    std::cout << std::fixed; // 출력 자릿수 고정(~소수점)
    std::cout << A/B;
    return 0;
}
/* stdio.h를 사용할 경우
--------------------
#include <stdio.h>

int main() {
    double A; double B;
    scanf("%lf %lf", &A,&B);
    printf("%.16lf", A/B);
    // 오차 범위를 지켜야 하기 때문에 double 자료형을 사용해 %lf,
    // 또한 9자리 이상으로 출력해야 하기 때문에 .{n}으로 출력할 자릿수도 지정해줌
    return 0;
}
*/
