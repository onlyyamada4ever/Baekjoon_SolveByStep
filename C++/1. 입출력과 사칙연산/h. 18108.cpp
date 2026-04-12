#include <iostream>

int main() {
    int year;
    std::cin >> year;
    std::cout << year - 543;
    return 0;
}
/* stdio.h를 사용할 경우
--------------------
#include <stdio.h>
int main() {
    int year;
    scanf("%d", &year);
    printf("%d", year - 543);
    return 0;
}
*/