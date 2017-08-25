<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POS
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
        Me.listViewInvoicce = New System.Windows.Forms.ListView()
        Me.txtBxProductSearch = New System.Windows.Forms.TextBox()
        Me.lblProductId = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.CashRegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StocksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtboxQuantity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.lblAReceived = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblOr = New System.Windows.Forms.Label()
        Me.cboxType = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'listViewInvoicce
        '
        Me.listViewInvoicce.Location = New System.Drawing.Point(12, 79)
        Me.listViewInvoicce.Name = "listViewInvoicce"
        Me.listViewInvoicce.Size = New System.Drawing.Size(707, 318)
        Me.listViewInvoicce.TabIndex = 2
        Me.listViewInvoicce.UseCompatibleStateImageBehavior = False
        '
        'txtBxProductSearch
        '
        Me.txtBxProductSearch.Location = New System.Drawing.Point(739, 99)
        Me.txtBxProductSearch.Name = "txtBxProductSearch"
        Me.txtBxProductSearch.Size = New System.Drawing.Size(322, 22)
        Me.txtBxProductSearch.TabIndex = 3
        '
        'lblProductId
        '
        Me.lblProductId.AutoSize = True
        Me.lblProductId.Location = New System.Drawing.Point(736, 79)
        Me.lblProductId.Name = "lblProductId"
        Me.lblProductId.Size = New System.Drawing.Size(167, 17)
        Me.lblProductId.TabIndex = 4
        Me.lblProductId.Text = "Barcode / Product Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(476, 410)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Total Amount:        ₱"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Location = New System.Drawing.Point(616, 410)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(44, 17)
        Me.lblTotalAmount.TabIndex = 6
        Me.lblTotalAmount.Text = "00.00"
        '
        'CashRegisterToolStripMenuItem
        '
        Me.CashRegisterToolStripMenuItem.Enabled = False
        Me.CashRegisterToolStripMenuItem.Name = "CashRegisterToolStripMenuItem"
        Me.CashRegisterToolStripMenuItem.Size = New System.Drawing.Size(110, 24)
        Me.CashRegisterToolStripMenuItem.Text = "&Cash Register"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.ProductsToolStripMenuItem.Text = "P&roducts"
        '
        'ClosToolStripMenuItem
        '
        Me.ClosToolStripMenuItem.Name = "ClosToolStripMenuItem"
        Me.ClosToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.ClosToolStripMenuItem.Text = "Clos&e"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CashRegisterToolStripMenuItem, Me.StocksToolStripMenuItem, Me.ProductsToolStripMenuItem, Me.ClosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1120, 28)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StocksToolStripMenuItem
        '
        Me.StocksToolStripMenuItem.Name = "StocksToolStripMenuItem"
        Me.StocksToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.StocksToolStripMenuItem.Text = "&Stocks"
        '
        'txtboxQuantity
        '
        Me.txtboxQuantity.Location = New System.Drawing.Point(961, 252)
        Me.txtboxQuantity.Name = "txtboxQuantity"
        Me.txtboxQuantity.Size = New System.Drawing.Size(100, 22)
        Me.txtboxQuantity.TabIndex = 10
        Me.txtboxQuantity.Text = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(881, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Quantity:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(476, 485)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Change:                ₱"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Location = New System.Drawing.Point(613, 485)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(44, 17)
        Me.lblChange.TabIndex = 13
        Me.lblChange.Text = "00.00"
        '
        'lblAReceived
        '
        Me.lblAReceived.AutoSize = True
        Me.lblAReceived.Location = New System.Drawing.Point(613, 440)
        Me.lblAReceived.Name = "lblAReceived"
        Me.lblAReceived.Size = New System.Drawing.Size(44, 17)
        Me.lblAReceived.TabIndex = 15
        Me.lblAReceived.Text = "00.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(476, 440)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Amount Received: ₱"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Official Receipt:"
        '
        'lblOr
        '
        Me.lblOr.AutoSize = True
        Me.lblOr.Location = New System.Drawing.Point(126, 56)
        Me.lblOr.Name = "lblOr"
        Me.lblOr.Size = New System.Drawing.Size(0, 17)
        Me.lblOr.TabIndex = 17
        '
        'cboxType
        '
        Me.cboxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxType.FormattingEnabled = True
        Me.cboxType.Location = New System.Drawing.Point(961, 296)
        Me.cboxType.Name = "cboxType"
        Me.cboxType.Size = New System.Drawing.Size(100, 24)
        Me.cboxType.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(861, 299)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Buyer Type:"
        '
        'POS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 595)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboxType)
        Me.Controls.Add(Me.lblOr)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblAReceived)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtboxQuantity)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblProductId)
        Me.Controls.Add(Me.txtBxProductSearch)
        Me.Controls.Add(Me.listViewInvoicce)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "POS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listViewInvoicce As System.Windows.Forms.ListView
    Friend WithEvents txtBxProductSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblProductId As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotalAmount As System.Windows.Forms.Label
    Friend WithEvents CashRegisterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StocksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtboxQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblChange As System.Windows.Forms.Label
    Friend WithEvents lblAReceived As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblOr As System.Windows.Forms.Label
    Friend WithEvents cboxType As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
