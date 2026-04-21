Time = input()
T_toCook = int(input())
P_Time = Time.split()
P_Hour = int(P_Time[0])
P_Minute = int(P_Time[1])
result = P_Hour * 60 + P_Minute + T_toCook
if result / 60 >= 24:
    result -= 24 * 60
print(result // 60, result % 60)
