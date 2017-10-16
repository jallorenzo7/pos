Public Class frmLogIn
    Dim checking As Integer = 1
    Private Sub frmLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlBox = False
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        If Me.txtUsername.Text = "" Or Me.txtboxPassword.Text = "" Then
            MsgBox("Please fill the requirements needed")
        Else
            sql = "SELECT * from users where username = '" + Me.txtUsername.Text + "'"
            Dim password As String = Md5FromString(Me.txtboxPassword.Text)
            If getUser(sql) Then
                If Me.txtUsername.Text = db_username And password = db_password Then
                    logged_in_role = db_role
                    MsgBox("Welcome '" + txtUsername.Text + "'", MsgBoxStyle.OkOnly)
                    Me.Close()
                    pos.Enabled = True
                    printReceipt.lblEmployeeId.Text = db_id
                    printReceipt.lblEmpName.Text = db_name
                    getLoginForm()
                Else
                    MsgBox("User does not exist in the database")
                    checking = checking + 1
                End If
            Else
                MsgBox("User does not exist in the database")
                checking = checking + 1
            End If
            If checking = 4 Then
                Me.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        pos.Close()
    End Sub

End Class