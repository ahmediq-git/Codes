'                             Online VB Compiler.
'                 Code, Compile, Run and Debug VB program online.
' Write your code in this editor and press "Run" button to execute it.


Module VBModule
    
    Sub Addmatrices(Byval matrix1(,) as Integer, Byval matrix2(,) as Integer, Byval Ansmatrix(3,3) As Integer)
        dim row,col as integer
        for row=1 to 3
            for col=1 to 3
                Ansmatrix(row,col)=matrix1(row,col)+matrix2(row,col)
            Next
        Next
    End Sub
    

    Sub Main()
        Dim twoDarray(10, 20) As Integer
        
        dim row as Integer
        dim col as Integer
        
        ' Assigning 3 for every value in the array
        for row=1 to 10
            for col=1 to 20
                twoDarray(row,col)=3
            Next
        Next
        
        
        ' Printing the array above
        for row=1 to 10
            for col=1 to 20
                console.write(twoDarray(row,col) &" ")
            Next
            console.writeline()
        Next
        
        
        console.writeline()
        console.writeline("Now we will take addition of 2 matrices of dimension 3 by 3")
        console.writeline()
        
        ' Taking input from user
        Dim matrix1(3, 3) As Integer
        
        for row=1 to 3
            for col=1 to 3
                console.writeline("What do you input in row "& row & " column " & col)
                matrix1(row,col)=console.readline()
            Next
        Next
    
        
        ' Assume both matrices have same dimensions
        
        ' Addition of 2 matrices
        
        ' Declaring and inputting secondmatrix
        Dim matrix2(3, 3) As Integer
         
        for row=1 to 3
            for col=1 to 3
                console.writeline("What do you input in row "& row & " column " & col)
                matrix2(row,col)=console.readline()
            Next
        Next
        
        
        Dim Ansmatrix(3,3) As Integer
        Addmatrices(matrix1, matrix2,Ansmatrix)
        
        
        ' Printing the first and second matrices before their addition
        console.writeline("Your first matrix was: ")
        for row=1 to 3
            for col=1 to 3
                console.write(matrix1(row,col) &" ")
            Next
            console.writeline()
        Next
        
        
        console.writeline("Your second matrix was: ")
        for row=1 to 3
            for col=1 to 3
                console.write(matrix2(row,col) &" ")
            Next
            console.writeline()
        Next
        
        
        ' Printing the addtion of both matrices
        console.writeline("Your Answer is: ")
        for row=1 to 3
            for col=1 to 3
                console.write(Ansmatrix(row,col) &" ")
            Next
            console.writeline()
        Next
        
        
        
    End Sub
End Module
