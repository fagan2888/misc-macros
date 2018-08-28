Sub RunMe()
Dim x, lRow As Integer

lRow = Range("A" & Rows.Count).End(xlUp).Row
x = 1
Sheets("Sheet1").Select
With Sheets("Sheet2")
    Do
        x = x + 1
        If Cells(x, "N").Value <> vbNullString Then
            .Range("A" & Rows.Count).End(xlUp).Offset(1, 0) = Sheets("Sheet1").Cells(x, "I")
            .Range("B" & Rows.Count).End(xlUp).Offset(1, 0) = Sheets("Sheet1").Cells(x, "J")
            .Range("C" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "K").Value
            .Range("D" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "N").Value
            .Range("E" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "N").Value
            .Range("F" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "Q").Value
            .Range("G" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "Q").Value
            .Range("H" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "R").Value
            .Range("I" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "R").Value
            .Range("J" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "S").Value
            .Range("K" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "S").Value
            .Range("L" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "T").Value
            .Range("M" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "T").Value
            .Range("N" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "U").Value
            .Range("O" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "U").Value
            .Range("P" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "O").Value
            .Range("Q" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "O").Value
            .Range("R" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "P").Value
            .Range("S" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "P").Value
        End If
        If Cells(x, "V").Value <> vbNullString Then
            .Range("A" & Rows.Count).End(xlUp).Offset(1, 0) = Sheets("Sheet1").Cells(x, "I")
            .Range("B" & Rows.Count).End(xlUp).Offset(1, 0) = Sheets("Sheet1").Cells(x, "J")
            .Range("C" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "K").Value
            .Range("D" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "V").Value
            .Range("E" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "V").Value
            .Range("F" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "AA").Value
            .Range("G" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "AA").Value
            .Range("H" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "Y").Value
            .Range("I" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "Y").Value
            .Range("J" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "Z").Value
            .Range("K" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "Z").Value
            .Range("L" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "AB").Value
            .Range("M" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "AB").Value
            .Range("N" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "AC").Value
            .Range("O" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "AC").Value
            .Range("P" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "W").Value
            .Range("Q" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "W").Value
            .Range("R" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "X").Value
            .Range("S" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "X").Value
        End If
        If Cells(x, "AD").Value <> vbNullString Then
            .Range("A" & Rows.Count).End(xlUp).Offset(1, 0) = Sheets("Sheet1").Cells(x, "I")
            .Range("B" & Rows.Count).End(xlUp).Offset(1, 0) = Sheets("Sheet1").Cells(x, "J")
            .Range("C" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "K").Value
            .Range("D" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "AD").Value
            .Range("E" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "AD").Value
            .Range("F" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "AI").Value
            .Range("G" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "AI").Value
            .Range("H" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "AG").Value
            .Range("I" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "AG").Value
            .Range("J" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "AH").Value
            .Range("K" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "AH").Value
            .Range("L" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "AJ").Value
            .Range("M" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "AJ").Value
            .Range("N" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "AK").Value
            .Range("O" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "AK").Value
            .Range("P" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "AE").Value
            .Range("Q" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "AE").Value
            .Range("R" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "AF").Value
            .Range("S" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "AF").Value
        End If
    Loop Until x = lRow
End With
End Sub
