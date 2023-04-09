
text = "пример фразы шифрования"
key = "кондершсгй"

m = len (key)
n = len(text)
d = n//m
e=n%m
print("Ключ: " + key)
if e == 1:
	x = key[0]
	c=d*key+x
elif e ==2:
	x = key[0] + key[1]
	c = d*key+x
elif e == 3:
	x = key[0] + key[1] + key[2]
	c=d*key+x
elif e == 4:
	x = key[0] + key[1] + key[2] + key[3]
	c=d*key+x
elif e == 5:
	x = key[0] + key[1] + key[2] + key[3]+ key[4]
	c=d*key+x
elif e == 6:
	x = key[0] + key[1] + key[2] + key[3]+ key[4]+key[5]
	c=d*key+x
elif e == 7:
	x = key[0] + key[1] + key[2] + key[3]+ key[4]+key[5]+key[6]
	c=d*key+x
elif e == 8:
	x = key[0] + key[1] + key[2] + key[3]+ key[4]+key[5]+key[6] + key[7]
	c=d*key+x
elif e == 9:
	x = key[0] + key[1] + key[2] + key[3]+ key[4]+key[5]+key[6] + key[7] + key[8]
	c=d*key+x
elif e == 10:
	x = key[0] + key[1] + key[2] + key[3]+ key[4]+key[5]+key[6] + key[7] + key[8] + key[9]
	c=d*key+x
else:
	print(c)
print("Полученный ключ: "+ c)
print("Данный текст___: "+ text) 
s=str("")
t=str("")

for i in range(n):
	f = ord(text[i])+ ord(c[i])
	if f > 1103:
		q = f -1103
		w =chr(q)
		w.lower()
	s+= w.lower() 
print(s)

for i in range(len(s)):
	b = ord(s[i]) + 1103 - ord(c[i]) 
	if b > 31:
		q = b - 32
	w =chr(q)
	w.lower()
	t += w.lower()
print(t)