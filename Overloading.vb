
Module Module1
    
    ' Overloading: When you have two functions, or 2 procedures in a class, with the same name, but different parameters
    ' You put overloads in both functions, baaki kaam compiler ka he
    class greeting
        Public Overloads Sub hello()
            console.writeline("Hello")   
        End Sub
        
        Public Overloads Sub hello(ByVal name as String)
            console.writeline("Hello " & name)
        End Sub
    end class
    

    Public Sub Main()
       Dim myGreeting as New greeting
       myGreeting.hello()
       myGreeting.hello("Harris")
       Console.readkey
    End Sub

End Module