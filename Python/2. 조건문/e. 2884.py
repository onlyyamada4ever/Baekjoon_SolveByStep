inpt = input()
Time = inpt.split()
H = int(Time[0])
M = int(Time[1])
if M >= 45:
    M-=45
    print(H,M)
elif H > 0 and M < 45:
    H-=1
    M = M + 60 - 45
    print(H,M)
else:
    H = 23
    M = M + 60 - 45
    print(H,M)
