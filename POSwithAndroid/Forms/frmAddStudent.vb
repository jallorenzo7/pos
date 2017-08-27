Public Class frmAddStudent

    Private Sub frmAddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlBox = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmuserMange.Enabled = True
        Me.Close()
    End Sub

End Class