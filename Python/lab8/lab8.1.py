from nltk.book import *

def lexical_diversity(text):
	return len(text) / len(set(text))

def percentage(count, total):
	return 100 * count / total

print (text1)
print (text2)
print ("************************")
print (text1.similar("monstrous"))
print ("************************")
print (text2.similar("monstrous"))
print ("************************")
print (text2.common_contexts(["monstrous", "very"]))
print ("************************")

print("________________________________________")

text4.dispersion_plot(["citizens", "democracy", "freedom", "duties", "America"])

print (len(text3))
print("________________________________________")

print (set(text3))
t3 = sorted(set(text3))
print (t3)
print("________________________________________")
print (len(set(text3)))
print (len(text3) / len(set(text3)))
print("________________________________________")
print (text3.count("smote"))
print("________________________________________")
lexical_diversity(text3)
lexical_diversity(text5)
percentage(4, 5)
percentage(text4.count('a'),len(text4))
print("________________________________________")
print (sent1)
print (len(sent1))
lexical_diversity(sent1)
print("________________________________________")
str1 = ["holly", "xmas", "bell", "tree"]
str2 = ["egg", "rabbit", "Easter", "chocolate"]
print (str1+str2)
print (sent4 + sent1)
sent1.append("Some")
print (sent1)
print("________________________________________")
print (text4[173])
print (text4.index('awaken'))
print (text5[16715:16735])
print (text6[1600:1625])
print("________________________________________")
print (sorted(text6))
s =' '.join(['Monty', 'Python'])
print (s.split())
print("________________________________________")
fdist1 = FreqDist(text1)
print (fdist1)
vocabulary1 = fdist1.keys()
print (fdist1['whale'])
print (fdist1.plot(50, cumulative=True))
print("________________________________________")
V = set(text1)
long_words = [w for w in V if len(w) > 15]
long_words.sort()
print(long_words)
print("________________________________________")
f = bigrams(['more', 'is', 'said', 'than', 'done'])
for s in f:
	print (s)
print("________________________________________")

print (text4.collocations())
print (text8.collocations())