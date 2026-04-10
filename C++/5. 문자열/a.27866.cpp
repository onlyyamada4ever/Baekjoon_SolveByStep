#include <stdio.h>

int main() {
    char input[1000];
    int cord;
    scanf("%s", input);
    scanf("%d", &cord);
    printf("%c", input[cord-1]);
    return 0;
}
