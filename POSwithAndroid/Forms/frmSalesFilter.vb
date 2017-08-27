Public Class frmSalesFilter

    Private Sub frmSalesFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlBox = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmDailySalesReport.Show()
        frmDailySalesReport.lblDate.Text = Me.DateTimePicker1.Value.ToString
        frmDailySalesReport.loadReceipts(Format(Me.DateTimePicker1.Value, "MM/dd/yyyy"))
        Me.Close()
    End Sub
End Class