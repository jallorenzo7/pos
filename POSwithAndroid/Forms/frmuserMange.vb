Public Class frmuserMange
    Dim exist As Boolean
    Private Sub frmuserMange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlBox = False
        getLoginForm()
        loadUser()
    End Sub

    Private Sub CashRegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CashRegisterToolStripMenuItem.Click
        pos.Show()
        Me.Close()
    End Sub

    Private Sub InventoryToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmInventory.Show()
        Me.Close()
    End Sub

    Private Sub StocksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StocksToolStripMenuItem.Click
        frmStocks.Show()
        Me.Close()
    End Sub

    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsToolStripMenuItem.Click
        frmProducts.Show()
        Me.Close()
    End Sub

    Private Sub ClosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClosToolStripMenuItem.Click
        Me.Close()
        pos.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmAddStudent.btnAdd.Text = "&Add"
        frmAddStudent.Show()
        Me.Enabled = False
    End Sub

    Function loadUser()
        sql = "SELECT id, username, role FROM users"
        With Me.listUserManage
            .Clear()
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .Columns.Add("id", 100, HorizontalAlignment.Left)
            .Columns.Add("Username", 250, HorizontalAlignment.Left)
            .Columns.Add("Role", 100, HorizontalAlignment.Left)
        End With
        viewmysql(sql, "LogUser")
        Dim j As Integer
        Dim jCol As Integer = StrTable.Tables("LogUser").Columns.Count
        Dim m As Integer
        Dim mRow As Integer = StrTable.Tables("LogUser").Rows.Count
        Dim ItRow(1000) As String
        For m = 0 To mRow - 1
            For j = 0 To jCol - 1
                ItRow(j) = StrTable.Tables("LogUser").Rows(m).Item(j).ToString
            Next
            Dim lsvi As New ListViewItem(ItRow)
            If m / 2 <> Int(m / 2) Then
                lsvi.BackColor = Color.Lavender
            Else
                lsvi.BackColor = Color.White
            End If
            listUserManage.Items.Add(lsvi)
        Next
        clearVariables()
        Return (0)
    End Function

    Private Sub listUserManage_DoubleClick(sender As Object, e As EventArgs) Handles listUserManage.DoubleClick
        If listUserManage.SelectedItems.Item(0).Text.ToString Then
            Dim id As String = listUserManage.SelectedItems.Item(0).Text.ToString
            sql = "select * from users where id = " + id + ""
            exist = getUser(sql)
            If exist Then
                frmAddStudent.txtboxUserName.Text = db_username
                frmAddStudent.txtboxPassword.Text = db_password
                frmAddStudent.txtRetype.Text = db_password
                frmAddStudent.cboxRole.Text = db_role
                frmAddStudent.lblUserId.Text = db_id
                frmAddStudent.lblUserId.Visible = False
                frmAddStudent.btnAdd.Text = "&Update"
                frmAddStudent.Show()
                Me.Enabled = False
            End If
        End If

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        pos.Show()
        logged_in_role = ""
        getLoginForm()
        Me.Close()
    End Sub
End Class