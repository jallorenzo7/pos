Public Class frmInventoryAdd
    Dim sql As String
    Private Sub frmInventoryAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlBox = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frmStocks.Enabled = True
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Me.btnAdd.Text = "&Add Inventory" Then
            If Me.txtbxTransactionId.Text = "" Then
                MsgBox("Transaction Id must not be empty")
            Else
                sql = "transaction_id = " + Me.txtbxTransactionId.Text + " quantity = " + Me.txtBoxQuantity.Text + " product = " + Me.txtBoxProduct.Text + " data_of_arrival = " + Me.txtboxDateOfArrival.Text + " cost = " + Me.txtboxCost.Text

                MsgBox(sql)
            End If
        End If
    End Sub
End Class