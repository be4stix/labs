def bucketSort(a, n, buckets, m):  
    for j in range(m):
        buckets[j] = 0
    for i in range(n):
        buckets[a[i]] += 1
    i = 0
    for j in range(m):
        for k in range(buckets[j]):
            a[i] = j
            i += 1
A = (4,5,3,53,213,53,2,3)
bucketSort(A,len(A),)