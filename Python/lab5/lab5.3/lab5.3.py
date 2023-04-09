with open("input.txt",'r+') as inp:
    lines = inp.read()
with open("input.txt",'r+')as inp:
    for line in lines.splitlines():
        inp.write(str(len(line.split())) + ' ' + line + '\n')


