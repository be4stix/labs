text = """Через мгновение Алиса скользнула туда вслед за Кроликом, не успев и подумать, какие силы в мире помогут ей выбраться обратно.

Кроличья нора сначала шла прямо, подобно туннелю, и затем неожиданно обрывалась вниз, так неожиданно, что Алиса, не имея ни секунды, чтобы остановиться, упала в глубокий колодец.

Или колодец был очень глубок, или она падала очень медленно — во всяком случае, у неё было достаточно времени, пока она падала, осматриваться вокруг и гадать, что произойдёт дальше. Сначала Алиса попыталась заглянуть вниз, стараясь понять, куда она падает, но там было слишком темно, чтобы увидеть хоть что-нибудь.

Тогда она принялась разглядывать стены колодца и заметила, что на них были буфетные и книжные полки. Здесь и там она видела карты и картины, висящие на колышках. С одной из полок она сняла, летя вниз, банку с наклейкой: «АПЕЛЬСИННЫЙ МАРМЕЛАД», но, к её величайшему разочарованию, банка оказалась пустой. Алиса не решилась бросить её, боясь убить кого-нибудь внизу. И она изловчилась и поставила банку в один из буфетов, мимо которого падала.

«Ну, — подумала Алиса, — после такого падения для меня просто пустяки слететь с лестницы. Какой храброй будут считать меня дома! Да что там! Я не скажу ни словечка, даже если свалюсь с крыши». (Что было очень похоже на правду.)

Вниз, вниз, вниз,вниз,вниз,вниз,вниз,вниз,вниз,... Кончится ли когда-нибудь падение?

"""

text1 = """All in the golden afternoon
Full leisurely we glide;
For both our oars, with little skill,
By little arms are plied,
While little hands make vain pretence
Our wanderings to guide.
 Ah, cruel Three! In such an hour.
Beneath such dreamy weather.
To beg a tale of breath too weak
To stir the tiniest feather!
Yet what can one poor voice avail
Against three tongues together?
 Imperious Prima flashes forth
Her edict "to begin it"—
In gentler tone Secunda hopes
"There will he nonsense in it!"—
While Tertia interrupts the tale
Not more than once a minute.
 Anon, to sudden silence won,
In fancy they pursue
The dream-child moving through a land
Of wonders wild and new,
In friendly chat with bird or beast—
And half believe it true."""

def Takeonewords(txt):
    s = txt.split()
    a = set(s)
    return len(a)
	

print("---1----")
k1 = text.count('вниз')/len(text)
k11 = text1.count('believe')/len(text1)
print (k1)
print (k11)

print("---2----")

p = text.count('.')
p1 = text1.count('.')
w = len(text)
w1 = len(text1)
k2 = 1 - p/w
k21 = 1 - p1/w1
print(k2)
print(k21)

print("---3----")
k3 = 15/3*len(text)
k31 = 15/3*len(text1)
print(k3)
print(k31)

print("---4----")
n = Takeonewords(text)
n1 = Takeonewords(text1)
k4 = n/len(text)
k41 = n1/len(text1)
print(k4)
print(k41)

print("---5----")
k4 = 1/ len(text)
k41 = 1/ len(text1)
print(k4)
print(k41)