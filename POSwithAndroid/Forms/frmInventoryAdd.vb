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
        If Me.btnAdd.Text = "&Add Inventory" Then
            If Me.txtbxTransactionId.Text = "" Then
                MsgBox("Transaction Id must not be empty")
            Else
                sql = "insert into stocks (transaction_id, quantity_onhand, quantity_initial, cost, arrival_date,) values ('" + Me.txtbxTransactionId.Text + "','" + Me.txtBoxQuantity.Text + "','" + Me.txtBoxQuantity.Text + "','" + Me.txtboxCost.Text + "','" + Me.txtdateTime.Value + "') product = " + Me.txtBoxProduct.Text + ""

                MsgBox(sql)
            End If
        End If
    End Sub
End Class