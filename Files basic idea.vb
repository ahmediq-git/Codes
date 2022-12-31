'                             Online VB Compiler.
'                 Code, Compile, Run and Debug VB program online.
' Write your code in this editor and press "Run" button to execute it.


Module VBModule
    Sub Main()
    ' Reading the first line in a file:
    
    Dim FileLine As String
    Dim ObjectReader As IO.StreamReader
    ObjectReader= New IO.StreamReader(“Camels.txt”)
    FileLine= ObjectReader.Readline()
    Console.Writeline(FileLine)
    ObjectReader.close()
    
    
    ' Reading all the lines in a File:
    
    ' Dim count as integer=0
    
    ' Dim FileLine As String
    ' Dim FileHandle As IO.StreamReader
    ' FileHandle= New IO.StreamReader(“Camels.txt”)
    
    ' Do While FileHandle.peek <> -1
    '     FileLine=FileHandle.Readline()
    '     Console.writeline(FileLine)
    '     count+=1
    ' Loop
    ' console.writeline("The number of lines are " & count)
    
    ' FileHandle.close()
    
    'Writing to a file named "Camels.txt"
    
    ' Dim FileLine As String
    ' FileLine="hello boi"
    ' Dim ObjectWriter As IO.StreamWriter
    ' ObjectWriter= New IO.StreamWriter(“Camels.txt”)
    ' ObjectWriter.writeline(FileLine)
    ' ObjectWriter.close()
    
    
    ' For writing to a file, and also taking the name of the file from user aswell
    
    ' dim Filename as String
    ' console.write("What do you want to name your file")
    ' Filename=Console.readline()
    ' Dim ObjectWriter As IO.StreamWriter
    ' ObjectWriter= New IO.Streamwriter(Filename)
    
    ' Dim FileLine As String
    ' console.write("What do you want to add to your file?")
    ' FileLine=Console.readline()
    ' ObjectWriter.writeline(FileLine)
    ' ObjectWriter.Close()
    
    
    
    ' For appending: (Just add true)
    
    ' Dim ObjectWriter As IO.StreamWriter
    ' ObjectWriter= New IO.Streamwriter("lol.txt", True)
    
    ' Dim FileLine As String
    ' console.write("What do you want to add to your file?")
    ' FileLine=Console.readline()

    
    ' ObjectWriter.writeline(FileLine)
    ' ObjectWriter.Close()
    
    End Sub
End Module
