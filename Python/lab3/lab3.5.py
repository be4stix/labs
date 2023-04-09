from random import randint
m = int(input("Введите размер :"))

A = [[randint(1, 10) for j in range(m)] for i in range(m)]
print(A)

n = int(input("Введите кол-во строк: "))
for i in range(0,n):
	for j in range (0,m):
		A[i][j] = 1
 
for j in range(0,m):
	c = A[n][j]
	A[n][j] = A[n+1][m-j-1]
	A[n+1][m-j-1] = c

for i in range(n+2,m):
	for j in range(0,m):
		A[i][j] = 0
print (A)

 