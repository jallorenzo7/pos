Public Class frmAddProduct

    Private Sub frmAddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlBox = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frmProducts.Enabled = True
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Me.txtbxProdName.Text = "" Then
            MsgBox("Product Name must not be empty.")
        Else
            If Me.btnAdd.Text = "&Add Product" Then
                Dim categ As String = Me.cboxCategory.SelectedValue
                sql = "insert into products (product_name, category_id, description, price, barcode) values ('" + Me.txtbxProdName.Text + "', '" + categ + "', '" + Me.txtboxDesc.Text + "', '" + Me.txtboxPrice.Text + "', '" + Me.txtboxBarCode.Text + "')"
                query(sql)
                frmProducts.loadProducts("")
                frmProducts.Enabled = True
                Me.Hide()
            ElseIf Me.btnAdd.Text = "Upda&te" Then
                Dim categ As String = Me.cboxCategory.SelectedValue
                sql = "update products set product_name = '" + Me.txtbxProdName.Text + "', category_id = '" + categ + "', description = '" + Me.txtboxDesc.Text + "', price = '" + Me.txtboxPrice.Text + "', barcode = '" + Me.txtboxBarCode.Text + "' where id = " + Me.lblProdId.Text
                query(sql)
                frmProducts.loadProducts("")
                frmProducts.Enabled = True
                Me.Hide()
            End If
        End If
    End Sub
End Class