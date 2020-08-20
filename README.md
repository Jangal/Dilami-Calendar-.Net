
# .Net Dilami Calendar

## Install

Just download and open it with Microsoft Visual Studio. You can use it with C# or Visual Basic.


## C# Example

```c#
using Dilami_Calendar_.Net;
using System;

namespace C_Sharp_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            DilamiCalendar dc = new DilamiCalendar(1398, 12, 2);

            Console.Write("Dilami Day: ");
            Console.WriteLine(dc.getDilamiDay());
            Console.Write("Dilami Month: ");
            Console.WriteLine(dc.getDilamiMonth());
            Console.Write("Dilami Year: ");
            Console.WriteLine(dc.getDilamiYear());

            Console.WriteLine();

            Console.WriteLine("IS " + dc.getDilamiYear() + " leap year? ");
            if (dc.isLeap())
            {
                Console.WriteLine("Yes!");
            }
            else
            {
                Console.WriteLine("No!");
            }

            Console.WriteLine();

            Console.Write("Jalali Day: ");
            Console.WriteLine(dc.getJalaliDay());
            Console.Write("Jalali Month: ");
            Console.WriteLine(dc.getJalaliMonth());
            Console.Write("Jalali Year: ");
            Console.WriteLine(dc.getJalaliYear());

            Console.ReadLine();
        }
    }
}

```

## Visual Basic Example

```visual basic
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

```

## Maybe You Like

[Python Dilami Calendar](https://github.com/Jangal/python-dilami-calendar)
<br/>
[Arduino Dilami Calendar](https://github.com/LordArma/Dilami-Calendar-Arduino)
<br/>
[تقویم دیلمی](http://giltime.ir)