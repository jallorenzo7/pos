Public Class frmInventoryAdd
    Dim sql As String
    Private Sub frmInventoryAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlBox = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frmStocks.Enabled = True
        Me.Hide()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim prod As String = Me.cboxProduct.SelectedValue
            If Me.txtbxTransactionId.Text = "" Then
                MsgBox("Transaction Id must not be empty")
            Else
                If Me.btnAdd.Text = "Upda&te" Then
                    sql = "update stocks set transaction_id = '" + Me.txtbxTransactionId.Text + "', quantity_onhand='" + Me.txtBoxQuantity.Text + "', quantity_initial='" + Me.txtBoxQuantity.Text + "', cost='" + Me.txtboxCost.Text + "', arrival_date='" + Me.txtdateTime.Value + "', product_id = '" + prod + "' where id = " + Me.lblStockId.Text
                    query(sql)
                    Me.txtbxTransactionId.Text = ""
                    Me.txtBoxQuantity.Text = ""
                    Me.txtboxCost.Text = ""
                frmStocks.loadStocks("", "desc")
                    frmStocks.Enabled = True
                    Me.Hide()
                Else
                    sql = "insert into stocks (transaction_id, quantity_onhand, quantity_initial, cost, arrival_date, product_id) values ('" + Me.txtbxTransactionId.Text + "','" + Me.txtBoxQuantity.Text + "','" + Me.txtBoxQuantity.Text + "','" + Me.txtboxCost.Text + "','" + Me.txtdateTime.Value + "','" + prod + "')"
                    query(sql)
                    Me.txtbxTransactionId.Text = ""
                    Me.txtBoxQuantity.Text = ""
                    Me.txtboxCost.Text = ""
                frmStocks.loadStocks("", "desc")
                    frmStocks.Enabled = True
                    Me.Hide()
                End If
            End If
    End Sub
End Class