 
letters = {"К":"11", "О":"12", "Н":"13","Д":"14", "Е":"15", "Р":"16", 
           "Ш":"21","С":"22", "Г":"23", "Й":"24","А":"25","Б":"26",
           "В":"31", "Ё":"32", "Ж":"33","З":"34", "И":"35", "Л":"36",
           "М":"41","П":"42", "Т":"43", "У":"44", "Ф":"45","Х":"46", 
           "Ц":"51", "Ч":"52", "Щ":"53","Ъ":"54", "Ы":"55", "Ь":"56", 
           "Э":"61","Ю":"62", "Я":"63",".":"64",",":"65","(":"66",
           ")":"71"}

numbers = {"11":"К", "12":"О", "13":"Н",
    "14":"Д","15":"Е", "16":"Р", "21":"Ш",
    "22":"С", "23":"Г", "24":"Й","25":"А",
    "26":"Б", "31":"В", "32":"Ё", "33":"Ж",
    "34":"З", "35":"И", "36":"Л", "41":"М",
    "42":"П", "43":"Т", "44":"У", "45":"Ф",
    "46":"Х", "51":"Ц", "52":"Ч", "53":"Щ",
    "54":"Ъ", "55":"Ы", "56":"Ь", "61":"Э",
    "62":"Ю", "63":"Я","64":".","65":",","66":"(","71":")"}

text = "Привет"
text2 = ""
text3 = ""

text = text.upper()
for elem in text:
    if elem in letters:
        text2 += letters.get(elem)
    else:
        text2 += (elem+elem)
print(text2)

i=0;
while i < len(text2)-1:
    if (text2[i]+text2[i+1] in numbers):
        text3 += numbers.get(text2[i]+text2[i+1])
    else:
        text3 += (text2[i]+text2[i])
    i+=2
print (text3)