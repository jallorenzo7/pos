Public Class frmStocks


    Private Sub frmStocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlBox = False
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

    Private Sub UserManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserManagementToolStripMenuItem.Click
        frmuserMange.Show()
        Me.Close()
    End Sub

    Private Sub ClosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClosToolStripMenuItem.Click
        Me.Close()
        POS.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmInventoryAdd.Show()
        Me.Enabled = False
    End Sub
End Class