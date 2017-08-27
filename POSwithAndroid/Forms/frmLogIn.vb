Public Class frmLogIn

    Private Sub frmLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlBox = False
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        If Me.txtUsername.Text = "" Or Me.txtboxPassword.Text = "" Then
            MsgBox("Please fill the requirements needed")
        Else
            sql = "SELECT * from users where username = '" + Me.txtUsername.Text + "'"
            If getUser(sql) Then
                If Me.txtUsername.Text = db_username And Me.txtboxPassword.Text = db_password Then
                    logged_in_role = db_role
                    Me.Close()
                    pos.Enabled = True
                    getLoginForm()
                Else
                    MsgBox("User does not exist in the database")
                End If
            Else
                MsgBox("User does not exist in the database")
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        pos.Close()
    End Sub
End Class