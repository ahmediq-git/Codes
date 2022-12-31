'                             Online VB Compiler.
'                 Code, Compile, Run and Debug VB program online.
' Write your code in this editor and press "Run" button to execute it.


Module VBModule
    Sub Main()
    dim myopt as Char    
    Do    
        console.writeline()
        console.writeline("(A) Read the full file")
        console.writeline("(B) Count the lines in an existing file")
        console.writeline("(C) Read from a certain line to the end")
        console.writeline("(D) Create new file and write to it")
        console.writeline("(E) Append to existing file")
        console.writeline("(F) Exit")
        console.writeline()
        
        Console.writeline()
        console.writeline("Enter your option: ")
        
        myopt=console.readline()
        console.writeline()
        
        Select myopt
            Case "A","a"
                Dim FileLine as String
                Dim ObjectReader as IO.StreamReader
                ObjectReader= New IO.StreamReader("Camels.txt")
                    Do While ObjectReader.peek <> -1
                        FileLine=ObjectReader.Readline()
                        Console.writeline(FileLine)
                    loop
                ObjectReader.close()
                
            Case "B","b"
                Dim count as integer=0
                Dim Filename as String
                Dim FileLine As String
                console.writeline("what is the file name u want to count the lines of ")
                Filename=console.readline()
                Dim FileHandle As IO.StreamReader
                FileHandle= New IO.StreamReader(Filename)
                Do While FileHandle.peek <> -1
                    FileLine=FileHandle.Readline()
                    'Console.writeline(FileLine)
                    count+=1
                Loop
                console.writeline("The number of lines are " & count)
                FileHandle.close()
            Case "C","c"
                Dim count as integer=0
                Dim Filename as String
                Dim FileLine As String
                Dim FileCount As integer
                console.writeline("what is the file name u want to count the lines of ")
                Filename=console.readline()
                
                console.writeline("what line do u want to read from? ")
                FileCount=console.readline
                Dim FileHandle As IO.StreamReader
                FileHandle= New IO.StreamReader(Filename)
                Do While FileHandle.peek <> -1
                    FileLine=FileHandle.Readline()
                    'Console.writeline(FileLine)
                    count+=1
                    if count>=FileCount Then
                        Console.writeline(FileLine)
                    end if
                Loop
                FileHandle.close()
            
            Case "D","d"
                dim Filename as String
                console.write("What do you want to name your file ")
                Filename=Console.readline()
                Dim ObjectWriter As IO.StreamWriter
                ObjectWriter= New IO.Streamwriter(Filename)
                
                Dim FileLine As String
                console.write("What do you want to add to your file? ")
                FileLine=Console.readline()
                ' Dim ObjectWriter As IO.StreamWriter
                ' ObjectWriter= New IO.StreamWriter()
                ObjectWriter.writeline(FileLine)
                ObjectWriter.Close() 'Keep close in lower case
            
            Case "E","e"
                Dim ObjectWriter As IO.StreamWriter
                Dim Filename as String
                console.writeline("what is the file name u want to append ")
                Filename=console.readline()
                ObjectWriter= New IO.Streamwriter(Filename, True)
                
                Dim FileLine As String
                console.write("What do you want to add to your file? ")
                FileLine=Console.readline()
                ObjectWriter.writeline(FileLine)
                ObjectWriter.Close()
                
            Case Else
                if myopt <>"F" Then
                        console.writeline("Invalid Option")
                End if
        End Select
        
    loop until myopt="F" or myopt="f"
    End Sub
End Module
