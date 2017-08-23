Public Class frmInventoryAdd

    Private Sub frmInventoryAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlBox = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frmInventory.Enabled = True
        Me.Close()
    End Sub
End Class