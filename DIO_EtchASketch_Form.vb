Public Class DIO_EtchASketch_Form
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Dim areuSure As MsgBoxResult
        areuSure = MsgBox("Would you like to exit?", MsgBoxStyle.YesNo)
        If areuSure = vbYes Then
            Me.Close()
        End If
    End Sub

End Class
