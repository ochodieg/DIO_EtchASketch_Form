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
        xCoordinate = 0
        yCoordinate = 0
        'allows last drawn line to remain unaltered if new line is drawn
    End Sub
    Sub PaintDo(x As Integer, y As Integer)
        'allows mouse to draw
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
        'allows the "left mouse" to erase 
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
        'allows the "left, middle, right - mouse" functions to enable on form. This is donw by calling upon them as a string. Recall CarrentalForm where e is dimmed as MouseEventArgs and the "ToString" allows functions to be called upon as strings [?].
    End Sub
    Private Sub SelectColorButton_Click(sender As Object, e As EventArgs) Handles selectcolorButton.Click
        ColorSelect()
        'selectColorButton calls upon the colorSelect sub
    End Sub
    Sub ColorSelect()
        ColorDialogSelect.ShowDialog()
        paintBrush.Color = ColorDialogSelect.Color
        'opens color select tool
    End Sub
    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ColorSelect()
    End Sub
    Public Sub ClearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        ClearBoard()
    End Sub
    Private Sub DrawwaveformsButton_Click(sender As Object, e As EventArgs) Handles drawwaveformsButton.Click
        'Clears Graphics before calling upon the DrawWaveforms sub
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
        Dim dialogOne As MsgBoxResult
        dialogOne = MsgBox("CLEARING!!!!!!")
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
            CanvasBox.Left = CanvasBox.Left + 25
            CanvasBox.Top = CanvasBox.Top + 25
            CanvasBox.Left = CanvasBox.Left - 50
            CanvasBox.Top = CanvasBox.Top - 50
            CanvasBox.Left = CanvasBox.Left + 50
            CanvasBox.Top = CanvasBox.Top + 50
            CanvasBox.Left = CanvasBox.Left - 25
            CanvasBox.Top = CanvasBox.Top - 25
            CanvasBox.Left = CanvasBox.Left + 35
            CanvasBox.Top = CanvasBox.Top + 35
            CanvasBox.Left = CanvasBox.Left - 60
            CanvasBox.Top = CanvasBox.Top - 60
            CanvasBox.Left = CanvasBox.Left + 60
            CanvasBox.Top = CanvasBox.Top + 60
            CanvasBox.Left = CanvasBox.Left - 35
            CanvasBox.Top = CanvasBox.Top - 35
            CanvasBox.Left = CanvasBox.Left + 55
            CanvasBox.Top = CanvasBox.Top + 55
            CanvasBox.Left = CanvasBox.Left - 80
            CanvasBox.Top = CanvasBox.Top - 80
            CanvasBox.Left = CanvasBox.Left + 80
            CanvasBox.Top = CanvasBox.Top + 80
            CanvasBox.Left = CanvasBox.Left - 55
            CanvasBox.Top = CanvasBox.Top - 55
        Next
        Dim dialog As MsgBoxResult
        dialog = MsgBox("all clear :>")

        'Clears the graphics.
        If visuals IsNot Nothing Then
            visuals.Clear(Color.FromName("Control"))
        End If
    End Sub
    'Sub Leftclick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
    '    '"e" is dimed as mouse event argument where mouse event arguments contain mouse info like: position, click, button pressed ..etc.
    '    If e.Button = MouseButtons.Right Then
    '        'If e.Button.ToString = "right" Then 
    '        'if mouse button clicked is the right mouse button.
    '        ContextMenuStrip.Show()
    '        ContextMenuStrip.Location = MousePosition
    '        'allows the context menu strip to appear where the position of the mouse was when right mouse button was clicked

    '    End If

    'End Sub

End Class