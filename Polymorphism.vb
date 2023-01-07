
Module Module1
    
    ' Parent should have overridable
    class Shape
        Protected areaValue as Decimal
        Protected perimeterValue as Decimal
        
        Overridable Sub area()
            console.writeline("Area " & areaValue)
        End Sub
        
        Overridable Sub perimeter()
            console.writeline("Area " & areaValue)
        End Sub
    end class
    
    
    'Child should have Overrides
    class rectangle: inherits Shape
        Private length as Decimal
        Private breadth as Decimal
        
        Public Sub New(Byval l as Decimal, Byval b as Decimal)
            length=l
            breadth=b
        End sub
        
        Overrides Sub Area()
            areaValue=length*breadth
            Console.writeline("Area "& areaValue)
        End Sub

    End Class

    'Child should have Overrides
    class circle: inherits Shape
        Private radius as Decimal
        
        Public Sub New(Byval r as Decimal)
            radius=r
        End sub
        
        Overrides Sub Area()
            areaValue=radius*radius*3.142
            Console.writeline("Area "& areaValue)
        End Sub
        
    End Class

    Public Sub Main()
        Dim myshape as New Shape
        myshape.Area()
        Dim myCircle as New circle(20)
        myCircle.Area()
        Dim myRectangle As New rectangle(10,17)
        myRectangle.area()
        Console.readkey()
    End Sub
    
    


End Module