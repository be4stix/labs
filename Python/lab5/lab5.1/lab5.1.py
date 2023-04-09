inp = open("input.txt",'r')
out = open("outlet.txt", 'w')

lines = inp.readlines()

for i in range(0, len(lines)):
    line = lines[i].split()

nums = []
for i in range(0,len(line)):
    nums.append(float(line[i]))

print(max(nums),file=out)
out.close()
inp.close()
