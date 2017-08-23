<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducts
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CashRegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StocksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.listProducts = New System.Windows.Forms.ListView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnProduct = New System.Windows.Forms.Button()
        Me.listCategory = New System.Windows.Forms.ListView()
        Me.btnCategory = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CashRegisterToolStripMenuItem, Me.StocksToolStripMenuItem, Me.ProductsToolStripMenuItem, Me.UserManagementToolStripMenuItem, Me.ClosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1120, 28)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CashRegisterToolStripMenuItem
        '
        Me.CashRegisterToolStripMenuItem.Name = "CashRegisterToolStripMenuItem"
        Me.CashRegisterToolStripMenuItem.Size = New System.Drawing.Size(110, 24)
        Me.CashRegisterToolStripMenuItem.Text = "&Cash Register"
        '
        'StocksToolStripMenuItem
        '
        Me.StocksToolStripMenuItem.Name = "StocksToolStripMenuItem"
        Me.StocksToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.StocksToolStripMenuItem.Text = "&Stocks"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.Enabled = False
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.ProductsToolStripMenuItem.Text = "P&roducts"
        '
        'UserManagementToolStripMenuItem
        '
        Me.UserManagementToolStripMenuItem.Name = "UserManagementToolStripMenuItem"
        Me.UserManagementToolStripMenuItem.Size = New System.Drawing.Size(142, 24)
        Me.UserManagementToolStripMenuItem.Text = "U&ser Management"
        '
        'ClosToolStripMenuItem
        '
        Me.ClosToolStripMenuItem.Name = "ClosToolStripMenuItem"
        Me.ClosToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.ClosToolStripMenuItem.Text = "Clos&e"
        '
        'listProducts
        '
        Me.listProducts.Location = New System.Drawing.Point(12, 74)
        Me.listProducts.Name = "listProducts"
        Me.listProducts.Size = New System.Drawing.Size(654, 509)
        Me.listProducts.TabIndex = 5
        Me.listProducts.UseCompatibleStateImageBehavior = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(157, 41)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(373, 22)
        Me.TextBox1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Product Search"
        '
        'btnProduct
        '
        Me.btnProduct.Location = New System.Drawing.Point(536, 37)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(130, 31)
        Me.btnProduct.TabIndex = 8
        Me.btnProduct.Text = "A&dd a product"
        Me.btnProduct.UseVisualStyleBackColor = True
        '
        'listCategory
        '
        Me.listCategory.Location = New System.Drawing.Point(690, 74)
        Me.listCategory.Name = "listCategory"
        Me.listCategory.Size = New System.Drawing.Size(409, 334)
        Me.listCategory.TabIndex = 9
        Me.listCategory.UseCompatibleStateImageBehavior = False
        '
        'btnCategory
        '
        Me.btnCategory.Location = New System.Drawing.Point(969, 423)
        Me.btnCategory.Name = "btnCategory"
        Me.btnCategory.Size = New System.Drawing.Size(130, 31)
        Me.btnCategory.TabIndex = 10
        Me.btnCategory.Text = "&Add a category"
        Me.btnCategory.UseVisualStyleBackColor = True
        '
        'frmProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 595)
        Me.Controls.Add(Me.btnCategory)
        Me.Controls.Add(Me.listCategory)
        Me.Controls.Add(Me.btnProduct)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.listProducts)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmProducts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CashRegisterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StocksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents listProducts As System.Windows.Forms.ListView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnProduct As System.Windows.Forms.Button
    Friend WithEvents listCategory As System.Windows.Forms.ListView
    Friend WithEvents btnCategory As System.Windows.Forms.Button
End Class
