Public Class frmSalesFilter

    Private Sub frmSalesFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlBox = False
        If Me.Text = "Sales Filter" Then
            Me.DateTimePicker2.Visible = False
            Me.lblFrom.Visible = False
            Me.lblTo.Text = "Pick a day"
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
        If Me.Text = "Sales Filter" Then
            frmDailySalesReport.Show()
            frmDailySalesReport.lblDate.Text = Me.DateTimePicker1.Value.ToString
            frmDailySalesReport.loadReceipts(Format(Me.DateTimePicker1.Value, "MM/dd/yyyy"))
            Me.Close()
        Else
            frmStockReport.Show()
            frmStockReport.lblFrom.Text = Me.DateTimePicker2.Value.ToString
            frmStockReport.lblTo.Text = Me.DateTimePicker1.Value.ToString
            frmStockReport.loadStocks(Format(Me.DateTimePicker2.Value, "MM/dd/yyyy"), Format(Me.DateTimePicker1.Value, "MM/dd/yyyy"))
        End If
    End Sub
End Class