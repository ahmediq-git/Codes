'                             Online VB Compiler.
'                 Code, Compile, Run and Debug VB program online.
' Write your code in this editor and press "Run" button to execute it.


Module VBModule
    Function enqueue(Byref QueueArray() As String, Byref Headptr As Integer, Byref Tailptr as Integer, Byref Totalitems As integer, Byval valtoadd As String) As Boolean
        If Totalitems=10 Then
            return False
        End if
        
        QueueArray(Tailptr)=valtoadd
        
        
        if Tailptr>=9 then 
            Tailptr=0
        Else
            Tailptr=Tailptr+1
        End if
        
        Totalitems=Totalitems+1 'total items is the number of items currently in the queue
        
        return True
    End Function
    
    
    Function dequeue(Byref QueueArray() As String, Byref Headptr As Integer, Byref Tailptr as Integer, Byref Totalitems As integer) As String
        If Totalitems=0 Then
            return "FALSE"
        End if
        
        Dim retValue as String
        retValue=QueueArray(Headptr)
        Headptr=Headptr+1
        
        if Headptr>=9 then 
            Headptr=0
        End if
        
        Totalitems=Totalitems-1 'total items is the number of items currently in the queue
        
        return retValue
    End Function
    
    Sub printArr(Byval QueueArray() As String, Byval Headptr as Integer, Byval Tailptr As Integer)
        Dim i as integer
        For i=Headptr to Tailptr
            console.writeline(QueueArray(i))
        Next
    End Sub

    Sub Main()
        Dim QueueArray (0 to 9) As String
        Dim Headptr As Integer =0
        Dim Tailptr As Integer=0
        Dim Totalitems As Integer=0
        Dim flag as Boolean=False

        Dim myinput As String
        Dim j as integer
        for j= 0 to 10
            console.writeline("enter a value")
            myinput=console.readline()
            flag=Enqueue(QueueArray, Headptr, Tailptr, Totalitems, myinput)
            
            if flag=False then
                console.writeline("Not added")
            Else
                console.writeline("Added")
            End if
        Next
        
        Dim removed1 As String =dequeue(QueueArray, Headptr, Tailptr, Totalitems)
        Dim removed2 As String =dequeue(QueueArray, Headptr, Tailptr, Totalitems)
        
        console.writeline("The first element removed is " & removed1 & "The second element is " & removed2)
    End Sub
    
End Module
