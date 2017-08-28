Public Class frmStockReport

    Private Sub frmStockReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlBox = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintDocument1.Print()
    End Sub

    Function loadStocks(ByVal from As String, ByVal fr As String)
        MsgBox(from)
        MsgBox(fr)
        sql = "SELECT transaction_id,product_id,quantity_onhand,quantity_initial,cost,arrival_date  FROM stocks where arrival_date > '" + from + " 00:00:00' and arrival_date < '" + fr + " 23:59:59'"
        With Me.listStocks
            .Clear()
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .Columns.Add("Transaction ID", 100, HorizontalAlignment.Left)
            .Columns.Add("Product", 100, HorizontalAlignment.Left)
            .Columns.Add("On-hand Quantity", 100, HorizontalAlignment.Left)
            .Columns.Add("Initial Quantity", 100, HorizontalAlignment.Left)
            .Columns.Add("Cost", 100, HorizontalAlignment.Left)
            .Columns.Add("Arrival Date", 100, HorizontalAlignment.Left)
        End With
        viewmysql(sql, "LogUser")
        Dim j As Integer
        Dim jCol As Integer = StrTable.Tables("LogUser").Columns.Count
        Dim m As Integer
        Dim mRow As Integer = StrTable.Tables("LogUser").Rows.Count
        Dim ItRow(1000) As String
        Dim temp As String = "0"
        For m = 0 To mRow - 1
            For j = 0 To jCol - 1
                If j = 1 Then
                    Dim id As String = StrTable.Tables("LogUser").Rows(m).Item(j).ToString
                    If String.IsNullOrEmpty(id) Then
                    Else
                        sql = "select * from products where id = " + id
                        getProduct(sql)
                        ItRow(j) = product_name
                    End If
                ElseIf j = 2 Then
                    ItRow(j) = StrTable.Tables("LogUser").Rows(m).Item(j).ToString
                    Dim q As String = StrTable.Tables("LogUser").Rows(m).Item(j).ToString
                    temp = Val(temp) + Val(q)
                Else
                    ItRow(j) = StrTable.Tables("LogUser").Rows(m).Item(j).ToString
                End If
            Next
            Dim lsvi As New ListViewItem(ItRow)
            If m / 2 <> Int(m / 2) Then
                lsvi.BackColor = Color.Lavender
            Else
                lsvi.BackColor = Color.White
            End If
            Me.listStocks.Items.Add(lsvi)
        Next
        Return (0)
    End Function
End Class