Option Strict On
Option Explicit On
'Ivan Ochoa
'RCET 0265
'Fall 2020
'EtchASketch_Form
'https://github.com/ochodieg/DIO_EtchASketch_Form

Public Class DIO_EtchASketch_Form ' PascalCase - TJR
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
    Sub delete(x As Integer, y As Integer) 'PascalCase
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
    Private Sub DrawwaveformsButton_Click(sender As Object, e As EventArgs) Handles drawwaveformsButton.Click ' PascalCase - TJR
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
        Dim GraphLine As New System.Drawing.Pen(Color.Black, 1) ' camelCase - TJR
        Dim SineWave As New System.Drawing.Pen(Color.Black, 3) ' camelCase - TJR
        Dim CoSineWave As New System.Drawing.Pen(Color.Red, 3) ' camelCase - TJR
        Dim TangentWave As New System.Drawing.Pen(Color.Blue, 3) ' camelCase - TJR
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
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim dialog As MsgBoxResult
        dialog = MsgBox("Draw with left mouse button." & vbNewLine &
            "Erase with right mouse button." & vbNewLine & vbNewLine &
            "Select your color with mouse wheel button." & vbNewLine &
            "If you don't have one, then use" & vbNewLine &
        "color menu option or 'shift' key. " & vbNewLine & vbNewLine &
        "Press 'enter' key to draw waveforms," & vbNewLine &
        "'Space' key to erase board," & vbNewLine & "'A' key to increase brush size and 'Z' key to decrease brush size" _
        & vbNewLine & "Press 'S' key to set brush to default size" & vbNewLine &
        "Brush size can also be set through 'Edit menu." & vbNewLine & vbNewLine &
        "Press 'Esc' key to exit program.")

    End Sub
    Public Sub DIO_EtchASketch_Form_keypress(sender As Object, e As KeyEventArgs) Handles CanvasBox.KeyUp
        'Access Keys are assigned by putting an "&" in the control text property. 
        'Example "E&xit" assigns Alt+x as the access key for the Exit Button - TJR

        'allows access keys. If statements determine what each set key does.
        If e.KeyCode = Keys.Enter Then
            DrawWaveforms()
        End If

        If e.KeyCode = Keys.Escape Then
            Exitshiz()
        End If

        If e.KeyCode = Keys.Space Then
            ClearBoard()
        End If

        If e.KeyCode = Keys.ShiftKey Then
            ColorSelect()
        End If

        If e.KeyCode = Keys.A Then
            paintBrush.Width += 2
        End If

        If e.KeyCode = Keys.Z Then
            paintBrush.Width -= 2
        End If

        If e.KeyCode = Keys.S Then
            paintBrush.Width = 1
        End If

    End Sub

    Private Sub DefaultBrushToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultBrushToolStripMenuItem.Click
        paintBrush.Width = 1
    End Sub

    Private Sub MediumBrushToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MediumBrushToolStripMenuItem.Click
        paintBrush.Width = 5
    End Sub

    Private Sub LargeBrushToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LargeBrushToolStripMenuItem.Click
        paintBrush.Width = 20
    End Sub

    Private Sub DefaultSizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultSizeToolStripMenuItem.Click
        wipeOff.Width = 20
    End Sub

    Private Sub MediumEraserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MediumEraserToolStripMenuItem.Click
        wipeOff.Width = 40
    End Sub

    Private Sub LargeEraserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LargeEraserToolStripMenuItem.Click
        wipeOff.Width = 70
    End Sub

    Private Sub FineEraserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FineEraserToolStripMenuItem.Click
        wipeOff.Width = 4
    End Sub

    Sub ClearBoard()
        Dim dialogOne As MsgBoxResult
        dialogOne = MsgBox("CLEARING!!!!!!")
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
        If visuals IsNot Nothing Then
            visuals.Clear(Color.FromName("Control"))
        End If
        'Prompts message, shakes canvas, and clears the graphics.
    End Sub

    'Remove commented code - TJR

End Class