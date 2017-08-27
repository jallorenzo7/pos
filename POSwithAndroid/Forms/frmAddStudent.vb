Public Class frmAddStudent

    Private Sub frmAddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlBox = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmuserMange.Enabled = True
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If Me.txtboxUserName.Text = "" Or Me.txtboxPassword.Text = "" Or Me.txtRetype.Text = "" Or Me.cboxRole.Text = "" Then
            MsgBox("Please fill up the the required information.")
        Else
            If Me.txtboxPassword.Text = Me.txtRetype.Text Then
                If Me.btnAdd.Text = "&Add" Then
                    Dim role As String = Me.cboxRole.Text
                    sql = "insert into users (username, password, role) values('" + Me.txtboxUserName.Text + "','" + Me.txtRetype.Text + "','" + role.ToLower + "')"
                    query(sql)
                    Me.txtRetype.Text = ""
                    Me.txtboxUserName.Text = ""
                    Me.txtboxPassword.Text = ""
                    Me.cboxRole.Text = ""
                    frmuserMange.Enabled = True
                    frmuserMange.loadUser()
                    Me.Close()
                Else
                    Dim role As String = Me.cboxRole.Text
                    sql = "update users set username='" + Me.txtboxUserName.Text + "', password='" + Me.txtRetype.Text + "', role='" + role.ToLower + "' where id=" + Me.lblUserId.Text
                    query(sql)
                    Me.txtRetype.Text = ""
                    Me.txtboxUserName.Text = ""
                    Me.txtboxPassword.Text = ""
                    Me.cboxRole.Text = ""
                    frmuserMange.Enabled = True
                    frmuserMange.loadUser()
                    Me.Close()
                End If
            Else
                MsgBox("Password does not match.")
            End If
        End If
    End Sub
End Class