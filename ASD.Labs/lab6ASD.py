import math


N = 9
 
G = [[0, 2, 3, 0, 0, 0, 0, 0, 0],
     [2, 0, 0, 7, 4, 0, 0, 0, 0],
     [3, 0, 0, 4, 6, 0, 0, 0, 0],
     [0, 7, 4, 0, 0, 0, 6, 8, 0],
     [0, 4, 6, 0, 0, 6, 3, 4, 0],
     [0, 0, 0, 9, 6, 0, 0, 0, 5],
     [0, 0, 0, 6, 3, 0, 0, 0, 7],
     [0, 0, 0, 8, 4, 0, 0, 0, 8],
     [0, 0, 0, 0, 0, 5, 7, 8, 0]]

selected_node = [0, 0, 0, 0, 0, 0, 0, 0, 0]

no_edge = 0

selected_node[0] = True

min = 0;
while (no_edge < N - 1):
    
    minimum = math.inf
    a = 0
    b = 0
    for m in range(N):
        if selected_node[m]:
            for n in range(N):
                if ((not selected_node[n]) and G[m][n]>0):  
                    if minimum > G[m][n]:
                        minimum = G[m][n]
                        a = m
                        b = n
    print(str(a) + "-" + str(b) + ":" + str(G[a][b]))
    min += G[a][b]
    selected_node[b] = True
    no_edge += 1
print(min)
