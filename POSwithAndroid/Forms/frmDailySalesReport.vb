﻿Public Class frmDailySalesReport

    Private Sub frmDailySalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlBox = False
    End Sub

    Function loadReceipts(ByVal ids As String, ByVal tor As String)
        sql = "SELECT id, quantity, total_amount, transaction_date FROM receipts where transaction_date between '" + ids + " 00:00:00' and '" + tor + " 23:59:59'"
        With Me.ListView1
            .Clear()
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .Columns.Add("Official Receipt", 125, HorizontalAlignment.Left)
            .Columns.Add("Quantity", 100, HorizontalAlignment.Left)
            .Columns.Add("Total Amount", 100, HorizontalAlignment.Left)
            .Columns.Add("Transaction Date", 100, HorizontalAlignment.Left)
        End With
        viewmysql(sql, "LogUser")
        Dim j As Integer
        Dim jCol As Integer = StrTable.Tables("LogUser").Columns.Count
        Dim m As Integer
        Dim mRow As Integer = StrTable.Tables("LogUser").Rows.Count
        Dim ItRow(1000) As String
        Dim tm_amount As String = "0"
        For m = 0 To mRow - 1
            For j = 0 To jCol - 1
                If j = 2 Then
                    Dim id As String = StrTable.Tables("LogUser").Rows(m).Item(j).ToString
                    tm_amount = Val(tm_amount) + Val(id)
                End If

                ItRow(j) = StrTable.Tables("LogUser").Rows(m).Item(j).ToString
            Next
            Dim lsvi As New ListViewItem(ItRow)
            ListView1.Items.Add(lsvi)
        Next
        Me.lblSales.Text = tm_amount
        clearVariables()
        Return 0
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintForm1.Print()
    End Sub
End Class