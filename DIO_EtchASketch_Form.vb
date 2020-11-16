Option Strict On
Option Explicit On
'Ivan Ochoa
'RCET 0265
'Fall 2020
'EtchASketch_Form

Public Class DIO_EtchASketch_Form
    Dim xCoordinate, yCoordinate As Integer
    Dim visuals As System.Drawing.Graphics
    Dim paintBrush As New System.Drawing.Pen(Color.Black, 1)
    Dim wipeOff As New System.Drawing.Pen(Color.FromName("control"), 10)
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Dim areuSure As MsgBoxResult
        areuSure = MsgBox("Would you like to exit?", MsgBoxStyle.YesNo)
        If areuSure = vbYes Then
            Me.Close()
        End If
    End Sub
    Private Sub CanvasBox_Noclick(sender As Object, e As MouseEventArgs) Handles CanvasBox.MouseUp
        xCoordinate = 0
        yCoordinate = 0
    End Sub
    Sub Paint(x As Integer, y As Integer)
        visuals = CanvasBox.CreateGraphics
        If xCoordinate = Nothing Then
            visuals.DrawLine(paintBrush, x, y, x, y)
        Else
            visuals.DrawLine(paintBrush, x, y, xCoordinate, yCoordinate)
        End If
        xCoordinate = x
        yCoordinate = y
    End Sub
    Sub delete(x As Integer, y As Integer)
        visuals = CanvasBox.CreateGraphics
        If xCoordinate = Nothing Then
            visuals.DrawLine(wipeOff, x, y, x, y)
        Else
            visuals.DrawLine(wipeOff, x, y, xCoordinate, yCoordinate)
        End If
        xCoordinate = x
        yCoordinate = y

    End Sub

End Class
