'                             Online VB Compiler.
'                 Code, Compile, Run and Debug VB program online.
' Write your code in this editor and press "Run" button to execute it.


Module VBModule
    Sub Main()

        dim myopt as char
        dim my_array(7) as integer
        
        do
            console.writeline()
            console.writeline("(A) Initialise Array")
            console.writeline("(B) Print Array")
            console.writeline("(C) change value at given index")
            console.writeline("(D) populate entire array")
            console.writeline("(E) Access index of array")
            console.writeline("(F) Linear Search the array")
            console.writeline("(G) Bubble sort the array")
            console.writeline("(H) Find the max value of the array")
            console.writeline("(I) Find the min value of the array")
            console.writeline("(J) Take sum of the array")
            console.writeline("(K) Remove from array")
            console.writeline("(L) Exit")
            
            console.writeline()
            console.write("Enter your option: ")

            myopt=console.readline()
            console.writeline()
            
            Select myopt
                Case "A","a"
                    dim count as integer
                    for count= 1 to 7
                        my_array(count)= -1
                    Next
                    console.writeline("Your array has been initialised")
                    
                Case "B","b"
                    dim count as integer
                    for count= 1 to 7
                        console.writeline(my_array(count))
                    Next
                    console.writeline("Your array has been printed")
                    
                Case "C","c"
                    console.writeline ("what index do u want to access?")
                    dim index as integer
                    index= console.readline
                    console.writeline ("your index value is "& my_array(index))
                    console.writeline ("what value do you want to change this to?")
                    dim change_val as integer
                    change_val = console.readline
                    my_array(index) = change_val
                    console.writeline ("the changed value is: "&my_array(index))
                    
                Case "D","d"
                  dim count as integer
                    for count= 1 to 7
                        console.writeline("enter a number:" )
                        my_array(count)=console.readline
                    Next
                    
                Case "E","e"
                    console.writeline ("what index do u want to access?")
                    dim index as integer
                    index= console.readline
                    console.writeline ("your index value is "& my_array(index))
                    
                Case "F","f"
                 dim search_value as integer
                 dim found as boolean
                 dim count as integer
                 found= False
                 count=1
                 console.writeline("enter a value to be searched")
                 search_value= console.readline
                    do while found= False and count<=7
                        
                        if search_value = my_array(count) then
                         found= True
                         Else
                         count=count+1
                        end if 
                     Loop
                    if found= True then
                            console.writeline("value is found")
                        Else
                            console.writeline ("value is not found")
                    end if
                    
                    
                Case "G","g"
                dim pass,comp,temp,N as integer
                N=6
                temp=0
                for pass = 1 to 7
                    for comp= 1 to N
                        if my_array(comp)>my_array(comp+1)then
                          temp=my_array(comp)
                          my_array(comp)=my_array(comp+1)
                          my_array(comp+1)=temp
                        end if
                    Next
                    N= N-1
                Next
                Case "H","h"
                    dim max as integer
                    dim count as integer
                    
                    max=my_array(1) 'You initialise max as very first array value to cover all the cases
                    
                    for count= 1 to 7
                        if my_array(count)>max then
                            max=my_array(count)
                        end if
                    Next
                    
                    console.writeline("The max value is: " & max)
                Case "I","i" 
                    dim min as integer
                    dim count as integer
                    
                    min=my_array(1) 'You initialise max as very first array value to cover all the cases
                    
                    for count= 1 to 7
                        if my_array(count)<min then
                            min=my_array(count)
                        end if
                        
                    Next
                    
                    console.writeline("The min value is: " & min)
                    
                Case "J","j"
                   dim sum as integer= 0
                   dim count as integer
                   for count= 1 to 7
                       sum= sum+my_array(count)
                   Next
                   console.writeline("the sum is: "&sum)
                   
                   
                Case "K","k"
                'assume that the value exists
                    dim delete_value as integer
                    dim found as boolean
                    dim count as integer
                    dim search_count as integer
                    dim temp as integer
                    found= False
                    count=1
                    temp=0
                    console.writeline ("enter a value to be deleted")
                    delete_value= console.readline
                    
                    
                    do while found= False and count<=7
                            if delete_value= my_array(count) then
                             found= True
                             search_count = count
                             Else
                             count=count+1
                            end if 
                    loop 
                    my_array(search_count)=0
                    
                    if found= True then                          'array is accessed from  its index
                     temp= my_array(search_count)                'index is different from the value at index, dont get confused
                     my_array(search_count)=my_array(7)           'For example over here you DONT DO my_array(delete_value) as delete_value is the value itself and not the index
                     my_array(7)=temp    
                    end if
                    
                  Case Else 
                    if myopt <>"L" Then
                        console.writeline("Invalid Option")
                    End if
            End Select
            
        Loop Until myopt="L"
    
    End Sub
End Module
