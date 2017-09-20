﻿Public Class printReceipt
    Private Sub printReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        MinimizeBox = False
    End Sub


    Function loadReceipts(ByVal ids As String)
        sql = "SELECT product_id, quantity, amount FROM product_receipt where receipt_id = '" + ids + "'"
        With Me.listDetail
            .Clear()
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .Columns.Add("Product", 125, HorizontalAlignment.Left)
            .Columns.Add("Quantity", 100, HorizontalAlignment.Left)
            .Columns.Add("Amount", 100, HorizontalAlignment.Left)
        End With
        viewmysql(sql, "LogUser")
        Dim j As Integer
        Dim jCol As Integer = StrTable.Tables("LogUser").Columns.Count
        Dim m As Integer
        Dim mRow As Integer = StrTable.Tables("LogUser").Rows.Count
        Dim ItRow(1000) As String
        For m = 0 To mRow - 1
            For j = 0 To jCol - 1
                If j = 0 Then
                    Dim id As String = StrTable.Tables("LogUser").Rows(m).Item(j).ToString
                    sql = "select * from products where id = " + id
                    getProduct(sql)
                    ItRow(j) = product_name
                Else
                    ItRow(j) = StrTable.Tables("LogUser").Rows(m).Item(j).ToString
                End If
            Next
            Dim lsvi As New ListViewItem(ItRow)
            listDetail.Items.Add(lsvi)
        Next
        clearVariables()
        Return 0
    End Function

    Private Sub listDetail_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintForm1.Print()
        Me.Close()
    End Sub
End Class