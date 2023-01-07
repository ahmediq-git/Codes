'                             Online VB Compiler.
'                 Code, Compile, Run and Debug VB program online.
' Write your code in this editor and press "Run" button to execute it.


Module VBModule
     Public Class complexnum
        Private Real As Integer
        Private Imaginary As Integer
    
        Public Sub New(ByVal r as integer, ByVal i as integer)
            Real=r
            Imaginary=i
        End Sub
        
        Public Sub PrintNum()
            console.write(Real & "+"& Imaginary)
            console.writeline("i")
        End Sub 
        
        Public Sub SetReal(ByVal r as integer)
            Real=r
        End Sub
        
        Public Sub SetImaginary(ByVal i as integer)
            Imaginary=i
        End Sub
        
        Public Function GetReal() as integer
            Return Real
        End Function
        
        Public Function GetImaginary() as integer
            Return Imaginary
        End Function
        
        Public Function AddNum(ByVal c2 as complexnum) as complexnum
            Dim Ans as New complexnum(0,0)
            Ans.Real=Real+c2.Real
            Ans.Imaginary=Imaginary+c2.Imaginary
            Return Ans
        End Function
        
        Public Function SubtractNum(ByVal c2 as complexnum) as complexnum
            Dim Ans as New complexnum(0,0)
            Ans.Real=Real-c2.Real
            Ans.Imaginary=Imaginary-c2.Imaginary
            Return Ans
        End Function
        
    End Class
    
    Sub Main()
        Dim c1 as New complexnum(2,3)
        Dim c2 as New complexnum(5,4)
        c1.PrintNum()
        c2.PrintNum()
        
        Dim FinalAns as New complexnum (0,0)
        FinalAns=c1.AddNum(c2)
        console.writeline() 'space left for better view
        FinalAns.PrintNum()
        FinalAns=c1.SubtractNum(c2)
        console.writeline()
        FinalAns.PrintNum()
        
        c1.SetReal(6)
        c1.SetImaginary(9)
        
        console.write(c1.GetReal() & "+"& c1.GetImaginary())
        console.writeline("i")
        
        FinalAns=c1.AddNum(c2)
        console.writeline() 'space left for better view
        FinalAns.PrintNum()
        
    End Sub
End Module
