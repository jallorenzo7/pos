Public Class frmStocks
    Dim exist As Boolean

    Private Sub frmStocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlBox = False
        loadStocks()
    End Sub

    Private Sub CashRegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CashRegisterToolStripMenuItem.Click
        POS.Show()
        Me.Close()
    End Sub

    Private Sub InventoryToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmInventory.Show()
        Me.Close()
    End Sub

    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsToolStripMenuItem.Click
        frmProducts.Show()
        Me.Close()
    End Sub

    Private Sub UserManagementToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmuserMange.Show()
        Me.Close()
    End Sub

    Private Sub ClosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClosToolStripMenuItem.Click
        Me.Close()
        POS.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmInventoryAdd.btnAdd.Text = "&Add Inventory"
        frmInventoryAdd.Text = "Add Inventory"
        frmInventoryAdd.txtbxTransactionId.Text = ""
        frmInventoryAdd.txtboxCost.Text = ""
        frmInventoryAdd.txtBoxQuantity.Text = ""
        frmInventoryAdd.txtdateTime.Value = ""
        frmInventoryAdd.lblStockId.Text = ""
        frmInventoryAdd.lblStockId.Visible = False
        frmInventoryAdd.Show()
        Me.Enabled = False
    End Sub

    Function loadStocks()
        sql = "SELECT * FROM stocks"
        With Me.listStocks
            .Clear()
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .Columns.Add("ID", 25, HorizontalAlignment.Left)
            .Columns.Add("Transaction ID", 100, HorizontalAlignment.Left)
            .Columns.Add("Product", 100, HorizontalAlignment.Left)
            .Columns.Add("On Hand Quantity", 100, HorizontalAlignment.Left)
            .Columns.Add("Initial Quantity", 100, HorizontalAlignment.Left)
            .Columns.Add("Cost", 100, HorizontalAlignment.Left)
            .Columns.Add("Arrival Date", 100, HorizontalAlignment.Left)
        End With
        viewmysql(sql, "LogUser")
        Dim j As Integer
        Dim jCol As Integer = StrTable.Tables("LogUser").Columns.Count
        Dim m As Integer
        Dim mRow As Integer = StrTable.Tables("LogUser").Rows.Count
        Dim ItRow(1000) As String
        For m = 0 To mRow - 1
            For j = 0 To jCol - 1
                If j = 2 Then
                    Dim id As String = StrTable.Tables("LogUser").Rows(m).Item(j).ToString
                    If String.IsNullOrEmpty(id) Then
                    Else
                        sql = "select * from products where id = " + id
                        getProduct(sql)
                        ItRow(j) = product_name
                    End If
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
            Me.listStocks.Items.Add(lsvi)
        Next
        Return (0)
    End Function

    Private Sub listStocks_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles listStocks.MouseDoubleClick
        If listStocks.SelectedItems.Item(0).Text.ToString Then
            Dim id As String = listStocks.SelectedItems.Item(0).Text.ToString
            sql = "select * from stocks where id = " + id + ""
            exist = getStock(sql)
            If exist Then
                frmInventoryAdd.btnAdd.Text = "Upda&te"
                frmInventoryAdd.Text = "Update a Stock"
                frmInventoryAdd.cboxProduct.SelectedValue = Val(stock_product_id)
                frmInventoryAdd.txtbxTransactionId.Text = stock_tId
                frmInventoryAdd.txtboxCost.Text = stock_cost
                frmInventoryAdd.txtBoxQuantity.Text = stock_quantity_initial
                frmInventoryAdd.txtdateTime.Value = stock_arrival_date
                frmInventoryAdd.lblStockId.Text = stock_id
                frmInventoryAdd.lblStockId.Visible = False
                frmInventoryAdd.Show()
                Me.Enabled = False
            End If
        End If
    End Sub

End Class