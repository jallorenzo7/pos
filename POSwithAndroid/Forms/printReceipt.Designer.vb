<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblThank = New System.Windows.Forms.Label()
        Me.lblOR = New System.Windows.Forms.Label()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblAmountReceived = New System.Windows.Forms.Label()
        Me.change = New System.Windows.Forms.Label()
        Me.subTotal = New System.Windows.Forms.Label()
        Me.Cash = New System.Windows.Forms.Label()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.vat = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.TotalAmount = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblReceiptNo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.listDetail = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblReceiptNo)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.listDetail)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(470, 471)
        Me.Panel1.TabIndex = 0
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
        Me.Panel2.Location = New System.Drawing.Point(18, 277)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(435, 190)
        Me.Panel2.TabIndex = 47
        '
        'lblThank
        '
        Me.lblThank.AutoSize = True
        Me.lblThank.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThank.Location = New System.Drawing.Point(118, 163)
        Me.lblThank.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblThank.Name = "lblThank"
        Me.lblThank.Size = New System.Drawing.Size(195, 17)
        Me.lblThank.TabIndex = 55
        Me.lblThank.Text = "Thank You Come Again!"
        '
        'lblOR
        '
        Me.lblOR.AutoSize = True
        Me.lblOR.Location = New System.Drawing.Point(100, 146)
        Me.lblOR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOR.Name = "lblOR"
        Me.lblOR.Size = New System.Drawing.Size(224, 17)
        Me.lblOR.TabIndex = 56
        Me.lblOR.Text = "THIS IS YOUR OFFICIAL RECEIPT"
        '
        'lblLine
        '
        Me.lblLine.AutoSize = True
        Me.lblLine.Location = New System.Drawing.Point(86, 129)
        Me.lblLine.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(248, 17)
        Me.lblLine.TabIndex = 54
        Me.lblLine.Text = "=============================="
        '
        'lblChange
        '
        Me.lblChange.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(282, 96)
        Me.lblChange.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(107, 20)
        Me.lblChange.TabIndex = 48
        Me.lblChange.Text = "0.00"
        Me.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDiscount
        '
        Me.lblDiscount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(282, 30)
        Me.lblDiscount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(107, 16)
        Me.lblDiscount.TabIndex = 49
        Me.lblDiscount.Text = "0.00"
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAmountReceived
        '
        Me.lblAmountReceived.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountReceived.Location = New System.Drawing.Point(282, 73)
        Me.lblAmountReceived.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAmountReceived.Name = "lblAmountReceived"
        Me.lblAmountReceived.Size = New System.Drawing.Size(107, 18)
        Me.lblAmountReceived.TabIndex = 50
        Me.lblAmountReceived.Text = "0.00"
        Me.lblAmountReceived.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'change
        '
        Me.change.AutoSize = True
        Me.change.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.change.Location = New System.Drawing.Point(31, 95)
        Me.change.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.change.Name = "change"
        Me.change.Size = New System.Drawing.Size(127, 23)
        Me.change.TabIndex = 52
        Me.change.Text = "Change    :"
        '
        'subTotal
        '
        Me.subTotal.AutoSize = True
        Me.subTotal.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subTotal.Location = New System.Drawing.Point(31, 30)
        Me.subTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.subTotal.Name = "subTotal"
        Me.subTotal.Size = New System.Drawing.Size(121, 17)
        Me.subTotal.TabIndex = 51
        Me.subTotal.Text = "Discount         :"
        '
        'Cash
        '
        Me.Cash.AutoSize = True
        Me.Cash.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cash.Location = New System.Drawing.Point(31, 73)
        Me.Cash.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Cash.Name = "Cash"
        Me.Cash.Size = New System.Drawing.Size(124, 17)
        Me.Cash.TabIndex = 53
        Me.Cash.Text = "Cash               :"
        '
        'lblVat
        '
        Me.lblVat.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVat.Location = New System.Drawing.Point(282, 10)
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
        Me.vat.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vat.Location = New System.Drawing.Point(31, 11)
        Me.vat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.vat.Name = "vat"
        Me.vat.Size = New System.Drawing.Size(119, 17)
        Me.vat.TabIndex = 47
        Me.vat.Text = "Subtotal         :"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(282, 52)
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
        Me.TotalAmount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAmount.Location = New System.Drawing.Point(31, 52)
        Me.TotalAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalAmount.Name = "TotalAmount"
        Me.TotalAmount.Size = New System.Drawing.Size(128, 17)
        Me.TotalAmount.TabIndex = 46
        Me.TotalAmount.Text = "Total Amount    :"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(287, 128)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(0, 20)
        Me.lblDate.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(226, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Date: "
        '
        'lblReceiptNo
        '
        Me.lblReceiptNo.AutoSize = True
        Me.lblReceiptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiptNo.Location = New System.Drawing.Point(143, 128)
        Me.lblReceiptNo.Name = "lblReceiptNo"
        Me.lblReceiptNo.Size = New System.Drawing.Size(0, 20)
        Me.lblReceiptNo.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Official Receipt: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(135, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = " +63(45)9613848"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(370, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "B Mendoza, San Fernando City, Pampanga 2000"
        '
        'listDetail
        '
        Me.listDetail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listDetail.Location = New System.Drawing.Point(0, 151)
        Me.listDetail.Name = "listDetail"
        Me.listDetail.Size = New System.Drawing.Size(464, 119)
        Me.listDetail.TabIndex = 1
        Me.listDetail.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Orchid's Bookstore"
        '
        'printReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 495)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "printReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "printReceipt"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents listDetail As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblReceiptNo As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblThank As System.Windows.Forms.Label
    Friend WithEvents lblOR As System.Windows.Forms.Label
    Friend WithEvents lblLine As System.Windows.Forms.Label
    Friend WithEvents lblChange As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblAmountReceived As System.Windows.Forms.Label
    Friend WithEvents change As System.Windows.Forms.Label
    Friend WithEvents subTotal As System.Windows.Forms.Label
    Friend WithEvents Cash As System.Windows.Forms.Label
    Friend WithEvents lblVat As System.Windows.Forms.Label
    Friend WithEvents vat As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents TotalAmount As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
