n = input()
List = []
a =n.split()
for i in a:
	
	List.append(i)

print(List)

for elem in List:
	if(int(elem[0])+int(elem[1]) != int(elem[2])+int(elem[3])):
		print(elem)