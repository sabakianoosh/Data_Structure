import numpy as np
import pandas as pd

def is_in_cartesian_prod(x, y, r):
    return r in [i+j for i in x.split(',') for j in y.split(',')]

def accept_CYK(w, G, S):
    if w == 'ε':
        return 'ε' in G[S]
    n = len(w)
    DP_table = [['']*n for _ in range(n)]
    for i in range(n):
        for lhs in G.keys():
            for rhs in G[lhs]:
                 if w[i] == rhs: # rules of the form A -> a
                    DP_table[i][i] = lhs if not DP_table[i][i] else DP_table[i][i] + ',' + lhs
                    
    for l in range(2, n+1):       # span
        for i in range(n-l+1):    # start
            j = i+l-1             # right
            for k in range(i, j): # partition
                for lhs in G.keys():
                    for rhs in G[lhs]:
                        if len(rhs) == 2: #rules of form A -> BC
                            if is_in_cartesian_prod(DP_table[i][k], DP_table[k+1][j], rhs):
                                if not lhs in DP_table[i][j]:
                                    DP_table[i][j] = lhs if not DP_table[i][j] else DP_table[i][j] + ',' + lhs

    return S in DP_table[0][n-1]  