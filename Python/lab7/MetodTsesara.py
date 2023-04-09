def encypt_func(txt, a): 
    result = "" 
    for i in range(len(txt)): 
        char = txt[i] 
        if(char.isupper()): 
            result += chr((ord(char) + a - 191)  + 192) 
        else: 
            result += chr((ord(char) + a - 223)  + 224) 
    return result 

def decrypt_func(txt, a): 
    result = "" 
    for i in range(len(txt)): 
        char = txt[i] 
        if(char.isupper()): 
            result += chr((ord(char) - a - 193)  + 192) 
        else: 
            result += chr((ord(char) - a - 225)  + 224) 
    return result 


txt = "Привет, я люблю Анечку" 
Shift = 3
 
code = encypt_func(txt, Shift)

print("Текст : " + txt) 
print("Переход : " + str(Shift)) 
print("Зашиврованная строка: " + code) 
print("Расшифровка: " + decrypt_func(code,Shift))
