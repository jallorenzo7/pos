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
        Me.listProducts = New System.Windows.Forms.ListView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listCategory = New System.Windows.Forms.ListView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCategory = New System.Windows.Forms.Button()
        Me.btnProduct = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'listProducts
        '
        Me.listProducts.Location = New System.Drawing.Point(12, 116)
        Me.listProducts.Name = "listProducts"
        Me.listProducts.Size = New System.Drawing.Size(764, 541)
        Me.listProducts.TabIndex = 5
        Me.listProducts.UseCompatibleStateImageBehavior = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(143, 81)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(497, 24)
        Me.TextBox1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Product Search"
        '
        'listCategory
        '
        Me.listCategory.Location = New System.Drawing.Point(791, 77)
        Me.listCategory.Name = "listCategory"
        Me.listCategory.Size = New System.Drawing.Size(317, 518)
        Me.listCategory.TabIndex = 9
        Me.listCategory.UseCompatibleStateImageBehavior = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.IndianRed
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1120, 71)
        Me.Panel1.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Snow
        Me.Button1.Image = Global.POSwithAndroid.My.Resources.Resources.back35px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 65)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Back      "
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCategory
        '
        Me.btnCategory.BackColor = System.Drawing.Color.IndianRed
        Me.btnCategory.FlatAppearance.BorderSize = 0
        Me.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategory.ForeColor = System.Drawing.Color.Snow
        Me.btnCategory.Image = Global.POSwithAndroid.My.Resources.Resources.login_box
        Me.btnCategory.Location = New System.Drawing.Point(822, 601)
        Me.btnCategory.Name = "btnCategory"
        Me.btnCategory.Size = New System.Drawing.Size(264, 47)
        Me.btnCategory.TabIndex = 10
        Me.btnCategory.Text = "&Add a category"
        Me.btnCategory.UseVisualStyleBackColor = False
        '
        'btnProduct
        '
        Me.btnProduct.BackColor = System.Drawing.Color.IndianRed
        Me.btnProduct.FlatAppearance.BorderSize = 0
        Me.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduct.ForeColor = System.Drawing.Color.Snow
        Me.btnProduct.Image = Global.POSwithAndroid.My.Resources.Resources.login_box
        Me.btnProduct.Location = New System.Drawing.Point(646, 77)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(130, 33)
        Me.btnProduct.TabIndex = 8
        Me.btnProduct.Text = "A&dd a product"
        Me.btnProduct.UseVisualStyleBackColor = False
        '
        'frmProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 682)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCategory)
        Me.Controls.Add(Me.listCategory)
        Me.Controls.Add(Me.btnProduct)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.listProducts)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProducts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listProducts As System.Windows.Forms.ListView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnProduct As System.Windows.Forms.Button
    Friend WithEvents listCategory As System.Windows.Forms.ListView
    Friend WithEvents btnCategory As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
