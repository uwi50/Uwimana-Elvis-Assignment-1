Module Module1

    Sub Main()
        Dim j As Integer
        Dim NameList As List(Of String) = New List(Of String)
        Dim OOPList As List(Of Decimal) = New List(Of Decimal)
        Dim JavaList As List(Of Decimal) = New List(Of Decimal)
        Dim CList As List(Of Decimal) = New List(Of Decimal)
        Dim StudName As String
        Dim OOP, Java, C As Decimal
        Dim AvgOOP, AvgJava, AvgC As Decimal
        AvgOOP = 0
        AvgJava = 0
        AvgC = 0
        Do
            Console.Write("Enter student name:")
            StudName = Console.ReadLine()

            If StudName <> LCase("N") Then
                NameList.Add(StudName)
                Console.Write(StudName & " OOP Grade:")
                OOP = Console.ReadLine()
                OOPList.Add(OOP)
                AvgOOP = AvgOOP + OOP
                Console.Write(StudName & " Java Grade:")
                Java = Console.ReadLine()
                JavaList.Add(Java)
                AvgJava = AvgJava + Java
                Console.Write(StudName & " C Grade:")
                C = Console.ReadLine()
                CList.Add(C)
                AvgC = AvgC + C

            End If
            Console.WriteLine(" ")
        Loop While StudName <> LCase("N")

        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine("List of students with their respective Grades:")
        Console.WriteLine("  ")
        Console.WriteLine("-----------------------------------")
        Console.WriteLine("  Student_Name     OOP   Java   C")
        Console.WriteLine("-----------------------------------")
        Console.WriteLine("  ")
        For j = 0 To NameList.Count - 1
            Console.WriteLine(j + 1 & ". " & NameList(j) & "         " & OOPList(j) & "     " & JavaList(j) & "    " & CList(j))
            Console.WriteLine(" ")
        Next
        Console.WriteLine(" ")
        Console.WriteLine("-----------------------------------")
        Console.WriteLine("  Average          " & AvgOOP / NameList.Count & "     " & AvgJava / NameList.Count & "     " & AvgC / NameList.Count)
        Console.WriteLine("-----------------------------------")
        Console.ReadLine()
    End Sub

End Module
