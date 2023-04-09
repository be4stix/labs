inp = open("input.txt",'r')
out = open("outlet.txt", 'w')

str = inp.readlines()
min = ""
k=0
for i in range(0, len(str)):
    strm = str[i].split()
    for j in range(0,len(strm)):
        if k == 0:
            min = strm[0];
            k=1;
        elif len(strm[j]) < len(min):
            min = strm[j]
print(min,file=out)
print(len(min),file=out)

out.close()
inp.close()
