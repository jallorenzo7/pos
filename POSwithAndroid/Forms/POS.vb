Public Class pos
    Private Sub InventoryToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        frmInventory.Show()
        Me.Hide()
    End Sub

    Private Sub StocksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StocksToolStripMenuItem.Click
        frmStocks.Show()
        Me.Hide()
    End Sub

    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsToolStripMenuItem.Click
        frmProducts.Show()
        Me.Hide()
    End Sub

    Private Sub UserManagementToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmuserMange.Show()
        Me.Hide()
    End Sub

    Private Sub ClosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClosToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub POS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlBox = False
        dbconn()
        typePopulate()
        categoryPopulate()
        productPopulate()
        newReceipts()
        loadReceipts()
    End Sub

    Private Sub txtBxProductSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBxProductSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            getProd(Me.txtBxProductSearch.Text)
        End If
    End Sub

    Private Sub txtboxQuantity_KeyDown(sender As Object, e As KeyEventArgs) Handles txtboxQuantity.KeyDown
        If e.KeyCode = Keys.Enter Then
            getProd(Me.txtBxProductSearch.Text)
        End If
    End Sub

    Function loadReceipts()
        sql = "SELECT id, product_id, quantity, amount FROM product_receipt where receipt_id = '" + Me.lblOr.Text + "'"
        With Me.listViewInvoicce
            .Clear()
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .Columns.Add("id", 1, HorizontalAlignment.Left)
            .Columns.Add("Product", 250, HorizontalAlignment.Left)
            .Columns.Add("Quantity", 100, HorizontalAlignment.Left)
            .Columns.Add("Amount", 175, HorizontalAlignment.Left)
        End With
        viewmysql(sql, "LogUser")
        Dim j As Integer
        Dim jCol As Integer = StrTable.Tables("LogUser").Columns.Count
        Dim m As Integer
        Dim mRow As Integer = StrTable.Tables("LogUser").Rows.Count
        Dim ItRow(1000) As String
        For m = 0 To mRow - 1
            For j = 0 To jCol - 1
                If j = 1 Then
                    Dim id As String = StrTable.Tables("LogUser").Rows(m).Item(j).ToString
                    sql = "select * from products where id = " + id
                    getProduct(sql)
                    ItRow(j) = product_name
                Else
                    ItRow(j) = StrTable.Tables("LogUser").Rows(m).Item(j).ToString
                End If
            Next
            Dim lsvi As New ListViewItem(ItRow)
            If m / 2 <> Int(m / 2) Then
                lsvi.BackColor = Color.Lavender
            Else
                lsvi.BackColor = Color.White
            End If
            listViewInvoicce.Items.Add(lsvi)
        Next
        clearVariables()
        Return (0)
    End Function

    Private Sub listViewInvoicce_ColumnWidthChanged(sender As Object, e As ColumnWidthChangedEventArgs) Handles listViewInvoicce.ColumnWidthChanged
        Static FireMe As Boolean = True
        If FireMe = True Then
            FireMe = False
            FireMe = True
        End If
    End Sub

    Private Sub listViewInvoicce_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs) Handles listViewInvoicce.ColumnWidthChanging
        e.Cancel = True
    End Sub

    Private Sub listViewInvoicce_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles listViewInvoicce.MouseDoubleClick
        If Me.listViewInvoicce.SelectedItems.Item(0).Text.ToString Then
            Dim id As String = Me.listViewInvoicce.SelectedItems.Item(0).Text.ToString
            Dim result As Integer = MessageBox.Show("Do you want to remove this item?", "POS", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                itemVoid(id)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNextCustomer.Click
        sql = "update receipts set transaction_date ='" + dateNos + "' where id = " + Me.lblOr.Text
        query(sql)
        newReceipts()
        loadReceipts()
        Me.lblAReceived.Text = "00.00"
        Me.lblChange.Text = "00.00"
        Me.lblTotalAmount.Text = "00.00"
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim amount As String = InputBox("Input amount received")
        cashOut(amount)
    End Sub
End Class
