Imports Dilami_Calendar_.Net

Module Program
    Sub Main(args As String())
        Dim dc As New DilamiCalendar(1398, 12, 2)

        Console.Write("Dilami Day: ")
        Console.WriteLine(dc.getDilamiDay())
        Console.Write("Dilami Month: ")
        Console.WriteLine(dc.getDilamiMonth())
        Console.Write("Dilami Year: ")
        Console.WriteLine(dc.getDilamiYear())

        Console.WriteLine()

        Console.WriteLine("IS " + Str(dc.getDilamiYear()) + " leap year? ")
        If dc.isLeap() = True Then

            Console.WriteLine("Yes!")
        Else
            Console.WriteLine("No!")
        End If

        Console.WriteLine()

        Console.Write("Jalali Day: ")
        Console.WriteLine(dc.getJalaliDay())
        Console.Write("Jalali Month: ")
        Console.WriteLine(dc.getJalaliMonth())
        Console.Write("Jalali Year: ")
        Console.WriteLine(dc.getJalaliYear())

        Console.ReadLine()

    End Sub
End Module
