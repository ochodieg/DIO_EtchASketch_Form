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
        Exitshiz()
    End Sub
    Sub Exitshiz()
        Dim areuSure As MsgBoxResult
        areuSure = MsgBox("Would you like to exit?", MsgBoxStyle.YesNo)
        If areuSure = vbYes Then
            Me.Close()
        End If
    End Sub
    Private Sub CanvasBox_Noclick(sender As Object, e As MouseEventArgs) Handles CanvasBox.MouseUp
        'Removes Reference point to draw if mouse is unclicked
        xCoordinate = 0
        yCoordinate = 0
    End Sub
    Sub PaintDo(x As Integer, y As Integer)
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
    Sub CanvasMouseMovement(sender As Object, e As MouseEventArgs) Handles CanvasBox.MouseDown, CanvasBox.MouseMove
        ActiveControl = CanvasBox
        If e.Button.ToString = "Left" Then
            PaintDo(e.X, e.Y)
        ElseIf e.Button.ToString = "Right" Then
            delete(e.X, e.Y)
        ElseIf e.Button.ToString = "Middle" Then
            ColorSelect()
        End If
    End Sub
    Private Sub SelectColorButton_Click(sender As Object, e As EventArgs) Handles selectcolorButton.Click
        ColorSelect()
    End Sub
    Sub ColorSelect()
        ColorDialogSelect.ShowDialog()
        paintBrush.Color = ColorDialogSelect.Color

    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ColorSelect()
    End Sub

    Public Sub ClearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        ClearBoard()
    End Sub

    Private Sub DrawwaveformsButton_Click(sender As Object, e As EventArgs) Handles drawwaveformsButton.Click
        'Clears Graphics.
        If visuals IsNot Nothing Then
            visuals.Clear(Color.FromName("Control"))
        End If
        DrawWaveforms()
    End Sub
    Sub DrawWaveforms()
        Dim x As Double
        Dim y As Double
        Dim xCoordinateTwo As Integer
        Dim yCoordinateTwo As Integer
        Dim GraphLine As New System.Drawing.Pen(Color.Black, 1)
        Dim SineWave As New System.Drawing.Pen(Color.Black, 3)
        Dim CoSineWave As New System.Drawing.Pen(Color.Red, 3)
        Dim TangentWave As New System.Drawing.Pen(Color.Blue, 3)
        visuals = CanvasBox.CreateGraphics
        For Cycles As Double = 0 To 1000
            y = Math.Sin(Cycles / 400 * 2 * Math.PI) * 100 + 150
            x = Cycles
            visuals.DrawLine(SineWave, CType(x, Single), CType(y, Single), CType(x, Single) + 1, CType(y, Single))
            'Draws a SinWave
        Next
        For Cycles As Double = 0 To 1000
            y = Math.Cos(Cycles / 400 * 2 * Math.PI) * 100 + 150
            x = Cycles
            visuals.DrawLine(CoSineWave, CType(x, Single), CType(y, Single), CType(x, Single) + 1, CType(y, Single))
            'Draws a CoSinWave
        Next
        For Cycles As Double = 0 To 1000
            y = Math.Tan(Cycles / 550 * 2 * Math.PI) * 20 + 150
            x = Cycles
            If xCoordinateTwo = Nothing Then
                xCoordinateTwo = CInt(x)
                yCoordinateTwo = CInt(y)
            ElseIf y - yCoordinateTwo < -50 Then
                xCoordinateTwo = CInt(x)
                yCoordinateTwo = CInt(y)
            End If
            visuals.DrawLine(TangentWave, CType(x, Single), CType(y, Single), xCoordinateTwo, yCoordinateTwo)
            yCoordinateTwo = CInt(y)
            xCoordinateTwo = CInt(x)
            'Draws a Tangent Wave
        Next
        For i = 1 To 10
            visuals.DrawLine(GraphLine, 62 * i, 500, 62 * i, -500)
            visuals.DrawLine(GraphLine, 1000, 34 * i, -1000, 34 * i)
            'Draws Graph Lines
        Next
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Exitshiz()
    End Sub

    Private Sub DrawWaveformToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DrawWaveformToolStripMenuItem.Click
        If visuals IsNot Nothing Then
            visuals.Clear(Color.FromName("Control"))
        End If
        DrawWaveforms()
    End Sub

    Private Sub DrawWaveformToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DrawWaveformToolStripMenuItem1.Click
        DrawWaveforms()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ClearBoard()
    End Sub

    Private Sub SelectColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectColorToolStripMenuItem.Click
        ColorSelect()
    End Sub

    'Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
    '    Dim dialog As MsgBoxResult
    '    dialog = MsgBox()
    'End Sub

    Sub ClearBoard()
        'This For loop 'shakes' the drawing picturebox.
        For i = 1 To 100
            CanvasBox.Left = CanvasBox.Left + 5
            CanvasBox.Top = CanvasBox.Top + 5
            CanvasBox.Left = CanvasBox.Left - 10
            CanvasBox.Top = CanvasBox.Top - 10
            CanvasBox.Left = CanvasBox.Left + 10
            CanvasBox.Top = CanvasBox.Top + 10
            CanvasBox.Left = CanvasBox.Left - 5
            CanvasBox.Top = CanvasBox.Top - 5
        Next
        'Clears the graphics.
        If visuals IsNot Nothing Then
            visuals.Clear(Color.FromName("Control"))
        End If
    End Sub
End Class
