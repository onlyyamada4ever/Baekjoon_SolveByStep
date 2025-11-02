# 문제 정보
# 100869번 사칙연산
# https://www.acmicpc.net/problem/100869
# 메모리 제한: 256 MB, 시간 제한: 1초

# 두 자연수 A와 B가 주어진다. 이때, A+B, A-B, A*B, A/B(몫), A%B(나머지)를 출력하는 프로그램을 작성하시오. 

a,b = input().split()
# 입력값을 .split() 함수로 공백 기준으로 분리 후 a, b 변수에 저장
print(int(a) + int(b)) # a + b 출력
print(int(a) - int(b)) # a - b 출력
print(int(a) * int(b)) # a * b 출력
print(int(a) // int(b)) 
# a // b 출력, 이번 문제에선 나눗셈의 몫을 소수X 정수만 출력해야하기 때문에 / 대신 // 사용 
print(int(a) % int(b)) # a % b 출력(나머지) 출력