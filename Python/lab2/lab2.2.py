import math

a = [1,2,3,4,5]

sum = math.fsum(a)
s = sum/5

pr = 1
for i in range(0,5):
    pr*= a[i]

q = math.pow(pr,1/5)
print ("Средний арифметический: ",s)
print ("Средний геометрический: ",q)
print (s + q)