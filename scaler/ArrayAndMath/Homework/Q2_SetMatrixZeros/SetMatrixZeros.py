


class Solution:
    # @param A : list of list of integers
    # @return the same list modified
    def setZeroes(self, A):
        iscol = False
        Row = len(A)
        Col = len(A[0])
        for i in range(Row):
            if A[i][0] == 0:
                iscol = True
            for j in range(1, Col):
                if A[i][j]  == 0:
                    A[0][j] = 0
                    A[i][0] = 0


        for i in range(1, Row):
            for j in range(1, Col):
                if not A[i][0] or not A[0][j]:
                    A[i][j] = 0


        if A[0][0] == 0:
            for j in range(Col):
                A[0][j] = 0

    
        if iscol:
            for i in range(Row):
                A[i][0] = 0