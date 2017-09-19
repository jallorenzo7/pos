Public Class frmSalesFilter

    Private Sub frmSalesFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlBox = False
        If Me.Text = "Sales Filter" Then
            Me.DateTimePicker2.Visible = True
            Me.lblFrom.Visible = True
            Me.lblFrom.Text = "From"
            Me.lblTo.Text = "To"
        Else
            Me.DateTimePicker2.Visible = True
            Me.lblFrom.Visible = True
            Me.lblFrom.Text = "From"
            Me.lblTo.Text = "To"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim presDate As String = Me.DateTimePicker1.Value.ToString("MM/dd/yyyy")
        If Me.Text = "Sales Filter" Then
            frmDailySalesReport.Show()
            frmDailySalesReport.lblDate.Text = Me.DateTimePicker1.Value.ToString("MM/dd/yyyy")
            frmDailySalesReport.lblTo.Text = Me.DateTimePicker2.Value.ToString("MM/dd/yyyy")
            frmDailySalesReport.loadReceipts(Me.DateTimePicker2.Value.ToString("MM/dd/yyyy"), presDate)
            Me.Close()
        Else
            frmStockReport.Show()
            frmStockReport.lblFrom.Text = Me.DateTimePicker2.Value.ToString("MM/dd/yyyy")
            frmStockReport.lblTo.Text = Me.DateTimePicker1.Value.ToString("MM/dd/yyyy")
            frmStockReport.loadStocks(Me.DateTimePicker2.Value.ToString("MM/dd/yyyy"), Me.DateTimePicker1.Value.ToString("MM/dd/yyyy"))
        End If
    End Sub
End Class