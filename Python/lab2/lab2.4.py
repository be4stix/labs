import math
a = [120, 146, 123, 160]
b = []

sum = math.fsum(a)
sr = sum/4
print ("Среднее значение времени", sr,"секунд")

for i in range (0,4):
    if(a[i] <= sr):
        b.append(i)
print ("Время лошадей",b,"не превышает среднее время")

winner = 0
for i in range(1,4):
    if(a[i] < a[winner]):
        winner = i
print ("Победила лошадь номер",winner+1)
