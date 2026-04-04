#include <iostream>

int main() {
    int A; int B;
    std::cin >> A >> B;

    std::cout << A+B << "\n";
    std::cout << A-B << "\n";
    std::cout << A*B << "\n";
    std::cout << A/B << "\n";
    std::cout << A%B << "\n";
    return 0;
}

/* stdio.h를 사용할 경우
#include <stdio.h>

int main() {
    int A; int B;
    scanf("%d %d", A, B);

    printf("%d", A+B);
    printf("%d", A-B);
    printf("%d", A*B);
    printf("%d", A/B);
    printf("%d", A%B);
    return 0;
}
*/