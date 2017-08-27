Public Class frmInventory

    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlBox = False
        loadReceipts()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pos.Enabled = True
        Me.Close()
    End Sub


    Function loadReceipts()
        If Me.TextBox1.Text = "" Then
            sql = "SELECT * FROM receipts ORDER BY id desc"
        Else
            sql = "SELECT * FROM receipts WHERE id =" + Me.TextBox1.Text + " ORDER BY id desc"
        End If
        With Me.listReceipt
            .Clear()
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .Columns.Add("Official Receipt", 50, HorizontalAlignment.Left)
            .Columns.Add("Buyer type", 100, HorizontalAlignment.Left)
            .Columns.Add("Quantity", 100, HorizontalAlignment.Left)
            .Columns.Add("Total Amount", 100, HorizontalAlignment.Left)
            .Columns.Add("Amount Received", 100, HorizontalAlignment.Left)
            .Columns.Add("Transaction Date", 100, HorizontalAlignment.Left)
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
            listReceipt.Items.Add(lsvi)
        Next
        clearVariables()
        Return (0)
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        loadReceipts()
    End Sub

    Private Sub listReceipt_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles listReceipt.MouseDoubleClick
        If listReceipt.SelectedItems.Item(0).Text.ToString Then
            Dim id As String = Me.listReceipt.SelectedItems.Item(0).Text.ToString
            Dim result As Integer = MessageBox.Show("Do you want to void this?", "POS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                sql = "DELETE from receipts where id =" + id
                query(sql)
                newReceipts()
                loadReceipts()
                Me.loadReceipts()
            End If
        End If
    End Sub

End Class