﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class printReceipt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(printReceipt))
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblEmpName = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblEmployeeId = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblThank = New System.Windows.Forms.Label()
        Me.lblOR = New System.Windows.Forms.Label()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblAmountReceived = New System.Windows.Forms.Label()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.change = New System.Windows.Forms.Label()
        Me.subTotal = New System.Windows.Forms.Label()
        Me.Cash = New System.Windows.Forms.Label()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.vat = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.TotalAmount = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblReceiptNo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.listDetail = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(60, 776)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(362, 260)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = resources.GetString("Label12.Text")
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(38, 744)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 20)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Business Style:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(65, 708)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(384, 17)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "==============================================="
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(61, 518)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(384, 17)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "==============================================="
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(61, 439)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(384, 17)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "==============================================="
        '
        'lblEmpName
        '
        Me.lblEmpName.AutoSize = True
        Me.lblEmpName.Location = New System.Drawing.Point(383, 473)
        Me.lblEmpName.Name = "lblEmpName"
        Me.lblEmpName.Size = New System.Drawing.Size(91, 17)
        Me.lblEmpName.TabIndex = 68
        Me.lblEmpName.Text = "Employee ID:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(262, 473)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 17)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Employee Name:"
        '
        'lblEmployeeId
        '
        Me.lblEmployeeId.AutoSize = True
        Me.lblEmployeeId.Location = New System.Drawing.Point(139, 473)
        Me.lblEmployeeId.Name = "lblEmployeeId"
        Me.lblEmployeeId.Size = New System.Drawing.Size(91, 17)
        Me.lblEmployeeId.TabIndex = 66
        Me.lblEmployeeId.Text = "Employee ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 473)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 17)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Employee ID:"
        '
        'lblThank
        '
        Me.lblThank.AutoSize = True
        Me.lblThank.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThank.Location = New System.Drawing.Point(118, 480)
        Me.lblThank.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblThank.Name = "lblThank"
        Me.lblThank.Size = New System.Drawing.Size(195, 17)
        Me.lblThank.TabIndex = 55
        Me.lblThank.Text = "Thank You Come Again!"
        '
        'lblOR
        '
        Me.lblOR.AutoSize = True
        Me.lblOR.Location = New System.Drawing.Point(100, 463)
        Me.lblOR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOR.Name = "lblOR"
        Me.lblOR.Size = New System.Drawing.Size(224, 17)
        Me.lblOR.TabIndex = 56
        Me.lblOR.Text = "THIS IS YOUR OFFICIAL RECEIPT"
        '
        'lblLine
        '
        Me.lblLine.AutoSize = True
        Me.lblLine.Location = New System.Drawing.Point(86, 446)
        Me.lblLine.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(248, 17)
        Me.lblLine.TabIndex = 54
        Me.lblLine.Text = "=============================="
        '
        'lblChange
        '
        Me.lblChange.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(282, 111)
        Me.lblChange.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(107, 20)
        Me.lblChange.TabIndex = 48
        Me.lblChange.Text = "0.00"
        Me.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDiscount
        '
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(282, 36)
        Me.lblDiscount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(107, 16)
        Me.lblDiscount.TabIndex = 49
        Me.lblDiscount.Text = "0.00"
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAmountReceived
        '
        Me.lblAmountReceived.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountReceived.Location = New System.Drawing.Point(282, 86)
        Me.lblAmountReceived.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAmountReceived.Name = "lblAmountReceived"
        Me.lblAmountReceived.Size = New System.Drawing.Size(107, 18)
        Me.lblAmountReceived.TabIndex = 50
        Me.lblAmountReceived.Text = "0.00"
        Me.lblAmountReceived.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblThank)
        Me.Panel2.Controls.Add(Me.lblOR)
        Me.Panel2.Controls.Add(Me.lblLine)
        Me.Panel2.Controls.Add(Me.lblChange)
        Me.Panel2.Controls.Add(Me.lblDiscount)
        Me.Panel2.Controls.Add(Me.lblAmountReceived)
        Me.Panel2.Controls.Add(Me.change)
        Me.Panel2.Controls.Add(Me.subTotal)
        Me.Panel2.Controls.Add(Me.Cash)
        Me.Panel2.Controls.Add(Me.lblVat)
        Me.Panel2.Controls.Add(Me.vat)
        Me.Panel2.Controls.Add(Me.lblTotal)
        Me.Panel2.Controls.Add(Me.TotalAmount)
        Me.Panel2.Location = New System.Drawing.Point(39, 539)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(435, 159)
        Me.Panel2.TabIndex = 65
        '
        'change
        '
        Me.change.AutoSize = True
        Me.change.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.change.Location = New System.Drawing.Point(31, 110)
        Me.change.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.change.Name = "change"
        Me.change.Size = New System.Drawing.Size(127, 23)
        Me.change.TabIndex = 52
        Me.change.Text = "Change    :"
        '
        'subTotal
        '
        Me.subTotal.AutoSize = True
        Me.subTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subTotal.Location = New System.Drawing.Point(31, 36)
        Me.subTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.subTotal.Name = "subTotal"
        Me.subTotal.Size = New System.Drawing.Size(111, 18)
        Me.subTotal.TabIndex = 51
        Me.subTotal.Text = "Discount          :"
        '
        'Cash
        '
        Me.Cash.AutoSize = True
        Me.Cash.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cash.Location = New System.Drawing.Point(31, 86)
        Me.Cash.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Cash.Name = "Cash"
        Me.Cash.Size = New System.Drawing.Size(107, 18)
        Me.Cash.TabIndex = 53
        Me.Cash.Text = "Cash               :"
        '
        'lblVat
        '
        Me.lblVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVat.Location = New System.Drawing.Point(282, 11)
        Me.lblVat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(107, 16)
        Me.lblVat.TabIndex = 44
        Me.lblVat.Text = "0.00"
        Me.lblVat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'vat
        '
        Me.vat.AutoSize = True
        Me.vat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vat.Location = New System.Drawing.Point(31, 12)
        Me.vat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.vat.Name = "vat"
        Me.vat.Size = New System.Drawing.Size(110, 18)
        Me.vat.TabIndex = 47
        Me.vat.Text = "VAT(12%)        :"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(282, 62)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(107, 16)
        Me.lblTotal.TabIndex = 45
        Me.lblTotal.Text = "0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalAmount
        '
        Me.TotalAmount.AutoSize = True
        Me.TotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAmount.Location = New System.Drawing.Point(31, 62)
        Me.TotalAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalAmount.Name = "TotalAmount"
        Me.TotalAmount.Size = New System.Drawing.Size(116, 18)
        Me.TotalAmount.TabIndex = 46
        Me.TotalAmount.Text = "Total Amount    :"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(322, 490)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(0, 20)
        Me.lblDate.TabIndex = 64
        '
        'lblReceiptNo
        '
        Me.lblReceiptNo.AutoSize = True
        Me.lblReceiptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiptNo.Location = New System.Drawing.Point(178, 490)
        Me.lblReceiptNo.Name = "lblReceiptNo"
        Me.lblReceiptNo.Size = New System.Drawing.Size(0, 20)
        Me.lblReceiptNo.TabIndex = 62
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 490)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 20)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Official Receipt: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(322, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "+00000000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(130, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(251, 80)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "ORCHIDS BLDG.V. TIOMICO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ST. SANTO ROSARIO POB" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CITY OF SN.FERNANDO PAMP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TIN# 10" & _
    "2-692-926-003VAT"
        '
        'listDetail
        '
        Me.listDetail.BackColor = System.Drawing.SystemColors.Menu
        Me.listDetail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listDetail.ForeColor = System.Drawing.SystemColors.WindowText
        Me.listDetail.Location = New System.Drawing.Point(15, 142)
        Me.listDetail.Name = "listDetail"
        Me.listDetail.Size = New System.Drawing.Size(464, 236)
        Me.listDetail.TabIndex = 57
        Me.listDetail.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 36)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Orchids Bookstore"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(261, 490)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Date: "
        '
        'printReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 1045)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblEmpName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblEmployeeId)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblReceiptNo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.listDetail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "printReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "printReceipt"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblEmpName As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeId As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblThank As System.Windows.Forms.Label
    Friend WithEvents lblOR As System.Windows.Forms.Label
    Friend WithEvents lblLine As System.Windows.Forms.Label
    Friend WithEvents lblChange As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblAmountReceived As System.Windows.Forms.Label
    Friend WithEvents PrintDocument2 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents change As System.Windows.Forms.Label
    Friend WithEvents subTotal As System.Windows.Forms.Label
    Friend WithEvents Cash As System.Windows.Forms.Label
    Friend WithEvents lblVat As System.Windows.Forms.Label
    Friend WithEvents vat As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents TotalAmount As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblReceiptNo As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents listDetail As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
