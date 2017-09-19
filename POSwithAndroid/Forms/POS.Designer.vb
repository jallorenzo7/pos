<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pos))
        Me.listViewInvoicce = New System.Windows.Forms.ListView()
        Me.txtBxProductSearch = New System.Windows.Forms.TextBox()
        Me.lblProductId = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CashRegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StocksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnNextCustomer = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnDailySales = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SystemTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'listViewInvoicce
        '
        Me.listViewInvoicce.Location = New System.Drawing.Point(38, 156)
        Me.listViewInvoicce.Name = "listViewInvoicce"
        Me.listViewInvoicce.Size = New System.Drawing.Size(707, 584)
        Me.listViewInvoicce.TabIndex = 2
        Me.listViewInvoicce.UseCompatibleStateImageBehavior = False
        '
        'txtBxProductSearch
        '
        Me.txtBxProductSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxProductSearch.Location = New System.Drawing.Point(12, 31)
        Me.txtBxProductSearch.Name = "txtBxProductSearch"
        Me.txtBxProductSearch.Size = New System.Drawing.Size(322, 40)
        Me.txtBxProductSearch.TabIndex = 1
        '
        'lblProductId
        '
        Me.lblProductId.AutoSize = True
        Me.lblProductId.Location = New System.Drawing.Point(776, 150)
        Me.lblProductId.Name = "lblProductId"
        Me.lblProductId.Size = New System.Drawing.Size(0, 17)
        Me.lblProductId.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(9, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Total Amount:       ₱"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 11.0!)
        Me.lblTotalAmount.Location = New System.Drawing.Point(232, 84)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(59, 24)
        Me.lblTotalAmount.TabIndex = 6
        Me.lblTotalAmount.Text = "00.00"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.IndianRed
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 9.0!)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(300, 300)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CashRegisterToolStripMenuItem, Me.StocksToolStripMenuItem, Me.ProductsToolStripMenuItem, Me.UserManagementToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.ClosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(210, 10, 0, 15)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(1167, 118)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CashRegisterToolStripMenuItem
        '
        Me.CashRegisterToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CashRegisterToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.CashRegisterToolStripMenuItem.Image = Global.POSwithAndroid.My.Resources.Resources.articlesketchup4
        Me.CashRegisterToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CashRegisterToolStripMenuItem.Name = "CashRegisterToolStripMenuItem"
        Me.CashRegisterToolStripMenuItem.Padding = New System.Windows.Forms.Padding(30, 0, 4, 10)
        Me.CashRegisterToolStripMenuItem.Size = New System.Drawing.Size(98, 93)
        Me.CashRegisterToolStripMenuItem.Text = "Main"
        Me.CashRegisterToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'StocksToolStripMenuItem
        '
        Me.StocksToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.StocksToolStripMenuItem.Image = Global.POSwithAndroid.My.Resources.Resources.mainstocks
        Me.StocksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.StocksToolStripMenuItem.Name = "StocksToolStripMenuItem"
        Me.StocksToolStripMenuItem.Padding = New System.Windows.Forms.Padding(30, 0, 4, 0)
        Me.StocksToolStripMenuItem.Size = New System.Drawing.Size(98, 93)
        Me.StocksToolStripMenuItem.Text = "&Stocks"
        Me.StocksToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.ProductsToolStripMenuItem.Image = Global.POSwithAndroid.My.Resources.Resources.prodmain
        Me.ProductsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Padding = New System.Windows.Forms.Padding(30, 0, 4, 0)
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(106, 93)
        Me.ProductsToolStripMenuItem.Text = "P&roducts"
        Me.ProductsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'UserManagementToolStripMenuItem
        '
        Me.UserManagementToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.UserManagementToolStripMenuItem.Image = Global.POSwithAndroid.My.Resources.Resources.mainuser
        Me.UserManagementToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UserManagementToolStripMenuItem.Name = "UserManagementToolStripMenuItem"
        Me.UserManagementToolStripMenuItem.Padding = New System.Windows.Forms.Padding(30, 0, 4, 0)
        Me.UserManagementToolStripMenuItem.Size = New System.Drawing.Size(98, 93)
        Me.UserManagementToolStripMenuItem.Text = "U&sers"
        Me.UserManagementToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.LogOutToolStripMenuItem.Image = Global.POSwithAndroid.My.Resources.Resources.mainlog
        Me.LogOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Padding = New System.Windows.Forms.Padding(30, 0, 4, 0)
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(99, 93)
        Me.LogOutToolStripMenuItem.Text = "Lo&g out"
        Me.LogOutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ClosToolStripMenuItem
        '
        Me.ClosToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.ClosToolStripMenuItem.Image = Global.POSwithAndroid.My.Resources.Resources.mainclose
        Me.ClosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ClosToolStripMenuItem.Name = "ClosToolStripMenuItem"
        Me.ClosToolStripMenuItem.Padding = New System.Windows.Forms.Padding(30, 0, 4, 0)
        Me.ClosToolStripMenuItem.Size = New System.Drawing.Size(98, 93)
        Me.ClosToolStripMenuItem.Text = "Clos&e"
        Me.ClosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'txtboxQuantity
        '
        Me.txtboxQuantity.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 11.0!)
        Me.txtboxQuantity.Location = New System.Drawing.Point(181, 249)
        Me.txtboxQuantity.Name = "txtboxQuantity"
        Me.txtboxQuantity.Size = New System.Drawing.Size(100, 31)
        Me.txtboxQuantity.TabIndex = 2
        Me.txtboxQuantity.Text = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(10, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 24)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Quantity:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(9, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 24)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Change:                ₱"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 11.0!)
        Me.lblChange.Location = New System.Drawing.Point(232, 201)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(59, 24)
        Me.lblChange.TabIndex = 13
        Me.lblChange.Text = "00.00"
        '
        'lblAReceived
        '
        Me.lblAReceived.AutoSize = True
        Me.lblAReceived.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 11.0!)
        Me.lblAReceived.Location = New System.Drawing.Point(232, 158)
        Me.lblAReceived.Name = "lblAReceived"
        Me.lblAReceived.Size = New System.Drawing.Size(59, 24)
        Me.lblAReceived.TabIndex = 15
        Me.lblAReceived.Text = "00.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 11.0!)
        Me.Label6.Location = New System.Drawing.Point(9, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(189, 24)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Amount Received:  ₱"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 7.8!)
        Me.Label5.Location = New System.Drawing.Point(35, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 18)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Official Receipt:"
        '
        'lblOr
        '
        Me.lblOr.AutoSize = True
        Me.lblOr.Location = New System.Drawing.Point(142, 136)
        Me.lblOr.Name = "lblOr"
        Me.lblOr.Size = New System.Drawing.Size(0, 17)
        Me.lblOr.TabIndex = 17
        '
        'cboxType
        '
        Me.cboxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxType.FormattingEnabled = True
        Me.cboxType.Location = New System.Drawing.Point(867, 488)
        Me.cboxType.Name = "cboxType"
        Me.cboxType.Size = New System.Drawing.Size(116, 28)
        Me.cboxType.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 7.8!)
        Me.Label7.Location = New System.Drawing.Point(755, 494)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 18)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Customer Type:"
        '
        'PrintDocument1
        '
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 11.0!)
        Me.lblDiscount.Location = New System.Drawing.Point(232, 121)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(59, 24)
        Me.lblDiscount.TabIndex = 26
        Me.lblDiscount.Text = "00.00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 11.0!)
        Me.Label8.Location = New System.Drawing.Point(9, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(186, 24)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Discount:              ₱"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.txtBxProductSearch)
        Me.GroupBox1.Controls.Add(Me.lblDiscount)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblTotalAmount)
        Me.GroupBox1.Controls.Add(Me.txtboxQuantity)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblChange)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblAReceived)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(765, 141)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(355, 310)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Barcode / Product Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnNextCustomer)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.btnDailySales)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(760, 550)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(369, 190)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cash Out"
        '
        'btnNextCustomer
        '
        Me.btnNextCustomer.BackColor = System.Drawing.Color.IndianRed
        Me.btnNextCustomer.Enabled = False
        Me.btnNextCustomer.FlatAppearance.BorderSize = 0
        Me.btnNextCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNextCustomer.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 9.0!)
        Me.btnNextCustomer.ForeColor = System.Drawing.Color.Snow
        Me.btnNextCustomer.Image = CType(resources.GetObject("btnNextCustomer.Image"), System.Drawing.Image)
        Me.btnNextCustomer.Location = New System.Drawing.Point(186, 31)
        Me.btnNextCustomer.Name = "btnNextCustomer"
        Me.btnNextCustomer.Size = New System.Drawing.Size(168, 67)
        Me.btnNextCustomer.TabIndex = 5
        Me.btnNextCustomer.Text = "&Next Customer>>"
        Me.btnNextCustomer.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.IndianRed
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 9.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Snow
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(12, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 66)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "&Amount Received"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnDailySales
        '
        Me.btnDailySales.BackColor = System.Drawing.Color.IndianRed
        Me.btnDailySales.FlatAppearance.BorderSize = 0
        Me.btnDailySales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDailySales.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 9.0!)
        Me.btnDailySales.ForeColor = System.Drawing.Color.Snow
        Me.btnDailySales.Image = CType(resources.GetObject("btnDailySales.Image"), System.Drawing.Image)
        Me.btnDailySales.Location = New System.Drawing.Point(187, 104)
        Me.btnDailySales.Name = "btnDailySales"
        Me.btnDailySales.Size = New System.Drawing.Size(168, 67)
        Me.btnDailySales.TabIndex = 24
        Me.btnDailySales.Text = "&Sales Report"
        Me.btnDailySales.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.IndianRed
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 9.0!)
        Me.Button3.ForeColor = System.Drawing.Color.Snow
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(12, 104)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(169, 66)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "&Transaction History"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(336, 134)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 17)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Date:"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Location = New System.Drawing.Point(384, 134)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(64, 17)
        Me.lbldate.TabIndex = 32
        Me.lbldate.Text = "12/12/12"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Location = New System.Drawing.Point(651, 134)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(64, 17)
        Me.lbltime.TabIndex = 33
        Me.lbltime.Text = "00:00:00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(602, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 17)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Time:"
        '
        'SystemTimer
        '
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.IndianRed
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 9.0!)
        Me.Button2.ForeColor = System.Drawing.Color.Snow
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(990, 468)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 67)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Discount"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'pos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1167, 792)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboxType)
        Me.Controls.Add(Me.lblOr)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblProductId)
        Me.Controls.Add(Me.listViewInvoicce)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
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
    Friend WithEvents btnNextCustomer As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents UserManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents btnDailySales As System.Windows.Forms.Button
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SystemTimer As System.Windows.Forms.Timer
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog

End Class
