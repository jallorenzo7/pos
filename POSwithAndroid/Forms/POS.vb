Public Class POS
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
    End Sub

    Private Sub txtBxProductSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBxProductSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            getProd(Me.txtBxProductSearch.Text)
        End If
    End Sub

    Function getProd(ByVal takeId As String)
        MsgBox(takeId)
        Return True
    End Function

End Class
