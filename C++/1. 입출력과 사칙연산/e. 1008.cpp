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
/*
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
