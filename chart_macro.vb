Option Explicit
Sub ColorScatterPoints()
    Dim cht As Chart
    Dim srs As Series
    Dim pt As Point
    Dim p As Long
    Dim Vals$, lTrim#, rTrim#
    Dim valRange As Range, cl As Range
    Dim myColor As Long

    Set cht = ActiveSheet.ChartObjects(1).Chart
    Set srs = cht.SeriesCollection(1)

   '## Get the series Y-Values range address:
    lTrim = InStrRev(srs.Formula, ",", InStrRev(srs.Formula, ",") - 1, vbBinaryCompare) + 1
    rTrim = InStrRev(srs.Formula, ",")
    Vals = Mid(srs.Formula, lTrim, rTrim - lTrim)
    Set valRange = Range(Vals)

    For p = 1 To srs.Points.Count
        Set pt = srs.Points(p)
        Set cl = valRange(p).Offset(0, 1) '## assume color is in the next column.

        With pt.Format.Fill
            .Visible = msoTrue
            '.Solid  'I commented this out, but you can un-comment and it should still work
            '## Assign Long color value based on the cell value
            '## Add additional cases as needed.
            Select Case LCase(cl)
                Case "red"
                    myColor = RGB(255, 0, 0)
                Case "orange"
                    myColor = RGB(255, 192, 0)
                Case "green"
                    myColor = RGB(0, 255, 0)
            End Select

            .ForeColor.RGB = myColor

        End With
    Next


End Sub