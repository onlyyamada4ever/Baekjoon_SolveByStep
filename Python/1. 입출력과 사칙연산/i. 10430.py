inpt = input().split()
A = int(inpt[0])
B = int(inpt[1])
C = int(inpt[2])

print( (A+B) %C )
print( ((A%C) + (B%C)) %C )
print( (A*B) %C )
print( ((A%C) * (B%C)) %C )
