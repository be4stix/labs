inp = open("input.txt",'r')
fout = open("outlet.txt", 'w')

lines = inp.readlines()
a = [[0 for j in range(len(lines))] for i in range(len(lines))]
d = []
for i in range(0, len(lines)):
    line = lines[i].split()
    for j in range(0,len(line)):
        a[i][j] = int(line[j])
for i in range(0, len(lines)):
    for j in range(0,len(line)):
        s = str(i)+str(j)
        ss = str(j) + str(i)
        if a[i][j] == 1 and s not in d and ss not in d:
            d.append(s)
print(a,file=fout)
print(d,file=fout)
fout.close()
inp.close()