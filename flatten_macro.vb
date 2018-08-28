Sub RunMe()
Dim x, lRow As Integer

lRow = Range("A" & Rows.Count).End(xlUp).Row
x = 1
Sheets("Sheet1").Select
With Sheets("Sheet2")
    Do
        x = x + 1
        If Cells(x, "C").Value <> vbNullString Then
            .Range("A" & Rows.Count).End(xlUp).Offset(1, 0) = Sheets("Sheet1").Cells(x, "A")
            .Range("B" & Rows.Count).End(xlUp).Offset(1, 0) = Sheets("Sheet1").Cells(x, "B")
            .Range("C" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "C").Value
            .Range("D" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "C").Value
        End If
        If Cells(x, "D").Value <> vbNullString Then
            .Range("A" & Rows.Count).End(xlUp).Offset(1, 0) = Sheets("Sheet1").Cells(x, "A")
            .Range("B" & Rows.Count).End(xlUp).Offset(1, 0) = Sheets("Sheet1").Cells(x, "B")
            .Range("C" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "D").Value
            .Range("D" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "D").Value
        End If
        If Cells(x, "E").Value <> vbNullString Then
            .Range("A" & Rows.Count).End(xlUp).Offset(1, 0) = Sheets("Sheet1").Cells(x, "A")
            .Range("B" & Rows.Count).End(xlUp).Offset(1, 0) = Sheets("Sheet1").Cells(x, "B")
            .Range("C" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "E").Value
            .Range("D" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "E").Value
        End If
        If Cells(x, "F").Value <> vbNullString Then
            .Range("A" & Rows.Count).End(xlUp).Offset(1, 0) = Sheets("Sheet1").Cells(x, "A")
            .Range("B" & Rows.Count).End(xlUp).Offset(1, 0) = Sheets("Sheet1").Cells(x, "B")
            .Range("C" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "F").Value
            .Range("D" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "F").Value
        End If
        If Cells(x, "G").Value <> vbNullString Then
            .Range("A" & Rows.Count).End(xlUp).Offset(1, 0) = Sheets("Sheet1").Cells(x, "A")
            .Range("B" & Rows.Count).End(xlUp).Offset(1, 0) = Sheets("Sheet1").Cells(x, "B")
            .Range("C" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "G").Value
            .Range("D" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "G").Value
        End If
        If Cells(x, "H").Value <> vbNullString Then
            .Range("A" & Rows.Count).End(xlUp).Offset(1, 0) = Sheets("Sheet1").Cells(x, "A")
            .Range("B" & Rows.Count).End(xlUp).Offset(1, 0) = Sheets("Sheet1").Cells(x, "B")
            .Range("C" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "H").Value
            .Range("D" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "H").Value
        End If
        If Cells(x, "I").Value <> vbNullString Then
            .Range("A" & Rows.Count).End(xlUp).Offset(1, 0) = Sheets("Sheet1").Cells(x, "A")
            .Range("B" & Rows.Count).End(xlUp).Offset(1, 0) = Sheets("Sheet1").Cells(x, "B")
            .Range("C" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "I").Value
            .Range("D" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "I").Value
        End If
        If Cells(x, "J").Value <> vbNullString Then
            .Range("A" & Rows.Count).End(xlUp).Offset(1, 0) = Sheets("Sheet1").Cells(x, "A")
            .Range("B" & Rows.Count).End(xlUp).Offset(1, 0) = Sheets("Sheet1").Cells(x, "B")
            .Range("C" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "J").Value
            .Range("D" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "J").Value
        End If
        If Cells(x, "K").Value <> vbNullString Then
            .Range("A" & Rows.Count).End(xlUp).Offset(1, 0) = Sheets("Sheet1").Cells(x, "A")
            .Range("B" & Rows.Count).End(xlUp).Offset(1, 0) = Sheets("Sheet1").Cells(x, "B")
            .Range("C" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "K").Value
            .Range("D" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "K").Value
        End If
        If Cells(x, "L").Value <> vbNullString Then
            .Range("A" & Rows.Count).End(xlUp).Offset(1, 0) = Sheets("Sheet1").Cells(x, "A")
            .Range("B" & Rows.Count).End(xlUp).Offset(1, 0) = Sheets("Sheet1").Cells(x, "B")
            .Range("C" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "L").Value
            .Range("D" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "L").Value
        End If
        If Cells(x, "M").Value <> vbNullString Then
            .Range("A" & Rows.Count).End(xlUp).Offset(1, 0) = Sheets("Sheet1").Cells(x, "A")
            .Range("B" & Rows.Count).End(xlUp).Offset(1, 0) = Sheets("Sheet1").Cells(x, "B")
            .Range("C" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "M").Value
            .Range("D" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "M").Value
        End If
        If Cells(x, "N").Value <> vbNullString Then
            .Range("A" & Rows.Count).End(xlUp).Offset(1, 0) = Sheets("Sheet1").Cells(x, "A")
            .Range("B" & Rows.Count).End(xlUp).Offset(1, 0) = Sheets("Sheet1").Cells(x, "B")
            .Range("C" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(1, "N").Value
            .Range("D" & Rows.Count).End(xlUp).Offset(1, 0) = Cells(x, "N").Value
        End If
        
    Loop Until x = lRow
End With
End Sub