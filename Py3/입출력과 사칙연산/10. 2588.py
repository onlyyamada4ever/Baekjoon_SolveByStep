Num1 = int(input())
Num2 = input() 
# 배열을 사용해서 자릿수를 나눠 계산해야 하기때문에 Num2 정수형으로 변환 X
print(Num1 * int(Num2[2]))
print(Num1 * int(Num2[1]))
print(Num1 * int(Num2[0]))
print(Num1 * int(Num2))
