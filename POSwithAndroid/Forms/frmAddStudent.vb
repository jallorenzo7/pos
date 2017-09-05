Public Class frmAddStudent

    Private Sub frmAddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlBox = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmuserMange.Enabled = True
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If Me.txtboxUserName.Text.Trim = "" Or Me.cboxRole.Text = "" Then
            MsgBox("Please fill up the the required information.")
        Else
            If Me.txtboxPassword.Text.Trim = Me.txtRetype.Text.Trim Then
                If Me.btnAdd.Text = "&Add" Then
                    Dim role As String = Me.cboxRole.Text
                    sql = "insert into users (name, username, password, role) values('" + Me.txtName.Text + "','" + Me.txtboxUserName.Text + "','" + Md5FromString(Me.txtRetype.Text) + "','" + role.ToLower + "')"
                    query(sql)
                    Me.txtRetype.Text = ""
                    Me.txtboxUserName.Text = ""
                    Me.txtboxPassword.Text = ""
                    Me.cboxRole.Text = ""
                    frmuserMange.Enabled = True
                    frmuserMange.loadUser()
                    Me.Close()
                Else
                    Dim pass As String
                    If Me.txtRetype.Text = "" Then
                        pass = db_password
                    Else
                        pass = Md5FromString(Me.txtRetype.Text)
                    End If

                    Dim role As String = Me.cboxRole.Text
                    sql = "update users set name='" + Me.txtName.Text + "', username='" + Me.txtboxUserName.Text + "', password='" + pass + "', role='" + role.ToLower + "' where id=" + Me.lblUserId.Text
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