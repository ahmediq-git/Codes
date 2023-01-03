'                             Online VB Compiler.
'                 Code, Compile, Run and Debug VB program online.
' Write your code in this editor and press "Run" button to execute it.


Module VBModule
    
    Public Class Cuboid
        public length as Integer
        public height as Integer
        public width as Integer
        
        ' A constructor runs automatically when you declare an object (any class variable basically)
        Public Sub New(ByVal l as Integer, Byval h as Integer, Byval w as Integer)   'constructor
            Console.WriteLine("This is your constructor")
            length=l
            height=h
            width=w
        End Sub
        
        Public Function SurfaceArea () as Integer
            Dim Area as Integer
            Area=2*length*width+2*width*height+2*length*height
            return Area
        End Function
        
        Public Function Volume () as Integer
            Dim myvolume as Integer
            myvolume=length*width*height
            return myvolume
        End Function
    End Class
    

    Sub Main()
        ' So you declare and initialise the values using constructor
        Dim c1 as New Cuboid(5,6,7)
        
        ' instead of this we use constructor notation above to initialise the values
    
        
        console.writeline("Cuboid 1:")
        console.writeline("The Surface Area is: " & c1.SurfaceArea())
        
        Dim vol_ans as Integer
        vol_ans=c1.Volume()
        
        console.writeline("The volume is: " & vol_ans)
    

        ' So to change values you must do assignment like this
        c1.length=6
        c1.height=9
        c1.width=6
        
        console.writeline("Cuboid 1: (values changed)")
        console.writeline("The Surface Area is: " & c1.SurfaceArea())
        
        
        Dim vol_an as Integer
        vol_an=c1.Volume()
        
        console.writeline("The volume is: " & vol_an)
        
        ' Or you must use setters and getters
        
        
        
        
        Dim c2 as New Cuboid(10, 15, 16)
        
        ' c2.length=10
        ' c2.height=15
        ' c2.width=16
        console.writeline("Cuboid 2:")
        console.writeline("The Surface Area is: " & c2.SurfaceArea())
        
        Dim vol_ans2 as Integer
        vol_ans2=c2.Volume()
        
        console.writeline("The volume is: " & vol_ans2)
        
    End Sub
End Module
