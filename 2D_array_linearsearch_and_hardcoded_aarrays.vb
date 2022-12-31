'                             Online VB Compiler.
'                 Code, Compile, Run and Debug VB program online.
' Write your code in this editor and press "Run" button to execute it.


Module VBModule
    Sub Linear_search(Byval matrix1(,))
        dim searchvalue as integer
        dim found as boolean=False
        
        console.writeline("What value do you want to search for: ")
        searchvalue=console.readline()
        
        
        dim row,col as integer
        for row=0 to 2
            for col=0 to 2
                if matrix1(row,col)=searchvalue Then
                    found=True
                end if
            Next
        Next
    
        
        if found=True Then
            console.writeline("Found")
        else
            console.writeline("Value is not found")
        end if
        
    End Sub
    

    Sub Main()
        ' When you declare an array directly (Hardcoding), remember to start the loop from 0 NOT 1
        Dim matrix1(,) As Integer={{1, 2, 3}, {4, 5, 6}, {7, 8, 9}}
    
        
        dim row,col as integer
        for row=0 to 2
            for col=0 to 2
               console.write(matrix1(row,col) & " ")
            Next
            console.writeline()
        Next
        
        
        Linear_search(matrix1)
        
        
        
        ' Printing 1d array that is hard coded
        Dim array1d() As Integer = {1,2,3,4,5}
        Dim i as integer
        for i=0 to 4
           console.writeline(array1d(i))
        Next
        
        console.readkey()
    End Sub
End Module
