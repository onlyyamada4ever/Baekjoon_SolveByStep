# 문제 정보
# 1000번 A+B  
# https://www.acmicpc.net/problem/1000 
# 메모리 제한: 256 MB, 시간 제한: 1초  

# 두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오.

a,b = input().split()
# 입력값을 .split() 함수로 공백 기준으로 분리 후 a, b 변수에 저장
print(int(a) + int(b))
# a, b 변수를 int() 함수로 정수형으로 변환 후 더한 값을 출력