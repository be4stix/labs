import math

print ("Введите длинну массива: ")
N = int(input())

A = [int(input())
    for i in range(N)]

pr=1

for i in range (0,N):
    pr*=A[i]

sr = math.pow(pr,1/N)

print ("Среднее геометрическое ", sr)
