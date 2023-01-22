'                             Online VB Compiler.
'                 Code, Compile, Run and Debug VB program online.
' Write your code in this editor and press "Run" button to execute it.


Module VBModule
    
    Public Class Cuboid
        private length as Integer
        private height as Integer
        private width as Integer
        
        ' A constructor runs automatically when you declare an object (any class variable basically)
        Public Sub New(ByVal l as Integer, Byval h as Integer, Byval w as Integer)   'constructor
            Console.WriteLine("This is your constructor")
            length=l
            height=h
            width=w
        End Sub
        
        Public Sub setlength(Byval l as integer)
            length=l
        End Sub
        
        Public Function getlength() As integer
            return length
        End Function
        
        
        ' You have to memorise this line for Destructor.
        'Destructor is a function that runs by itself at the ENDD of the program
        Protected Overrides Sub Finalize()
            Console.WriteLine("Object ended cuboid 1") 
            
        End Sub
        
        
    End Class
    
    Public Class Cuboid2
        private length as Integer
        private height as Integer
        private width as Integer
        
        ' A constructor runs automatically when you declare an object (any class variable basically)
        Public Sub New(ByVal l as Integer, Byval h as Integer, Byval w as Integer)   'constructor
            Console.WriteLine("This is your constructor")
            length=l
            height=h
            width=w
        End Sub
        
        Public Sub setlength(Byval l as integer)
            length=l
        End Sub
        
        Public Function getlength() As integer
            return length
        End Function
        
        
        ' You have to memorise this line for Destructor.
        'Destructor is a function that runs by itself at the ENDD of the program
        Protected Overrides Sub Finalize()
            Console.WriteLine("Object ended cuboid 2") 
            
        End Sub
        
        
    End Class
    

    Sub Main()
        ' So you declare and initialise the values using constructor
        ' NOTE:Don't use space inside constructor
        Dim c1 as New Cuboid(5,6,7)
        Dim c2 as New Cuboid2(6,9,6)
        
        
        'Testing getters
        console.writeline(c1.getlength())
        
        
        'Testing setters
        Dim l as integer
        console.writeline("what is l: ")
        l=console.readline()
        c1.setlength(l)
        
        console.writeline(c1.getlength())
 
        
    End Sub
End Module
























        