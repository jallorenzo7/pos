﻿Public Class frmProducts
    Dim exist As Boolean

    Private Sub CashRegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CashRegisterToolStripMenuItem.Click
        POS.Show()
        Me.Close()
    End Sub

    Private Sub frmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        ControlBox = False
        loadCategories()
        loadProducts("")
    End Sub

    Private Sub InventoryToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmInventory.Show()
        Me.Close()
    End Sub

    Private Sub StocksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StocksToolStripMenuItem.Click
        frmStocks.Show()
        Me.Close()
    End Sub

    Private Sub UserManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserManagementToolStripMenuItem.Click
        frmuserMange.Show()
        Me.Close()
    End Sub

    Private Sub ClosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClosToolStripMenuItem.Click
        Me.Close()
        POS.Close()
    End Sub

    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
        frmCategory.Show()
        Me.Enabled = False
    End Sub

    Function loadCategories()
        sql = "SELECT * FROM categories"
        With listCategory
            .Clear()
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .Columns.Add("ID", 25, HorizontalAlignment.Left)
            .Columns.Add("Category Name", 100, HorizontalAlignment.Left)
            .Columns.Add("Description", 175, HorizontalAlignment.Left)
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
            listCategory.Items.Add(lsvi)
        Next
        Return (0)
    End Function
    Function loadProducts(ByVal prodSearch As String)
        If prodSearch = "" Then
            prodSearch = "SELECT * FROM products"
        Else
            prodSearch = "SELECT * FROM products where product_name like '%" + prodSearch + "%'"
        End If
        With listProducts
            .Clear()
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .Columns.Add("ID", 25, HorizontalAlignment.Left)
            .Columns.Add("Product Name", 100, HorizontalAlignment.Left)
            .Columns.Add("Category", 75, HorizontalAlignment.Left)
            .Columns.Add("Description", 125, HorizontalAlignment.Left)
            .Columns.Add("Barcode", 100, HorizontalAlignment.Left)
            .Columns.Add("Price", 100, HorizontalAlignment.Left)
        End With
        viewmysql(prodSearch, "LogUser")
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
                        sql = "select * from categories where id = " + id
                        getCategory(sql)
                        ItRow(j) = category_name
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
            listProducts.Items.Add(lsvi)
        Next
        Return (0)
    End Function
    Private Sub listCategory_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles listCategory.MouseDoubleClick
        If listCategory.SelectedItems.Item(0).Text.ToString Then
            Dim id As String = listCategory.SelectedItems.Item(0).Text.ToString
            sql = "select * from categories where id = " + id + ""
            exist = getCategory(sql)
            If exist Then
                frmCategory.txtbxName.Text = category_name
                frmCategory.txtboxDescription.Text = category_description
                frmCategory.lblCategId.Text = category_id
                frmCategory.lblCategId.Visible = False
                frmCategory.btnAdd.Text = "Upda&te"
                frmCategory.Text = "Update a category"
                frmCategory.Show()
                Me.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
            categoryPopulate()
            frmAddProduct.cboxCategory.DataSource = categs.Tables(0)
            frmAddProduct.cboxCategory.ValueMember = "id"
            frmAddProduct.cboxCategory.DisplayMember = "category_name"
        frmAddProduct.Show()
        Me.Enabled = False
    End Sub

    Private Sub listProducts_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles listProducts.MouseDoubleClick
        If listProducts.SelectedItems.Item(0).Text.ToString Then
            Dim id As String = listProducts.SelectedItems.Item(0).Text.ToString
            sql = "select * from products where id = " + id + ""
            exist = getProduct(sql)
            If exist Then
                categoryPopulate()
                frmAddProduct.cboxCategory.DataSource = categs.Tables(0)
                frmAddProduct.cboxCategory.ValueMember = "id"
                frmAddProduct.cboxCategory.DisplayMember = "category_name"
                frmAddProduct.btnAdd.Text = "Upda&te"
                frmAddProduct.Text = "Update a product"
                frmAddProduct.cboxCategory.SelectedValue = product_category
                frmAddProduct.txtbxProdName.Text = product_name
                frmAddProduct.txtboxPrice.Text = product_price
                frmAddProduct.txtboxDesc.Text = product_description
                frmAddProduct.txtboxBarCode.Text = product_barcode
                frmAddProduct.lblProdId.Text = product_id
                frmAddProduct.lblProdId.Visible = False
                frmAddProduct.Show()
                Me.Enabled = False
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        loadProducts(Me.TextBox1.Text)
    End Sub

    Private Sub listProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listProducts.SelectedIndexChanged

    End Sub
End Class