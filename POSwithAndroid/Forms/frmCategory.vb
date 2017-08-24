Public Class frmCategory
    Dim sql As String
    Dim exist As Boolean
    Private Sub frmCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlBox = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frmProducts.Enabled = True
        Me.Hide()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Trim(Me.txtbxName.Text) = "" Then
            MsgBox("Category name must not be empty.", vbOKOnly)
        Else
            If Me.btnAdd.Text = "&Add" Then
                sql = "select * from categories where category_name = '" + Me.txtbxName.Text + "'"
                exist = checkCategory(sql)
                If exist = False Then
                    sql = "insert into categories (category_name,category_description) values ('" + Me.txtbxName.Text + "','" + Me.txtboxDescription.Text + "')"
                    query(sql)
                    Me.txtbxName.Text = ""
                    Me.txtboxDescription.Text = ""
                    frmProducts.Enabled = True
                    frmProducts.loadCategories()
                    Me.Hide()
                Else
                    MsgBox("Category already exists")
                End If
            ElseIf Me.btnAdd.Text = "Upda&te" Then
                sql = "update categories set category_name = '" + Me.txtbxName.Text + "', description = '" + Me.txtboxDescription.Text + "' where id = " + Me.lblCategId.Text
                query(sql)
                frmProducts.loadCategories()
                frmProducts.Enabled = True
                Me.Hide()
            End If
            
        End If
    End Sub

    Private Sub txtbxName_TextChanged(sender As Object, e As EventArgs) Handles txtbxName.TextChanged

    End Sub
End Class