
print ("Введите длинну массива: ")
N = int(input())
B = list()
A = [int(input())
    for i in range(N)]
print (A)

for i in range(0,N):
     q = i+1
     if ("2" in str(q)):
          B.append(A[i]) 

print(B)
B.sort()
B.reverse()
print(B)



