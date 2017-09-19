<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddProduct
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtbxProdName = New System.Windows.Forms.TextBox()
        Me.txtboxPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtboxBarCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtboxDesc = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblProdId = New System.Windows.Forms.Label()
        Me.cboxCategory = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Name:"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.IndianRed
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.Snow
        Me.btnClose.Image = Global.POSwithAndroid.My.Resources.Resources.login_box
        Me.btnClose.Location = New System.Drawing.Point(300, 401)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(113, 51)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.IndianRed
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.Snow
        Me.btnAdd.Image = Global.POSwithAndroid.My.Resources.Resources.login_box
        Me.btnAdd.Location = New System.Drawing.Point(171, 401)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(114, 51)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "&Add Product"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtbxProdName
        '
        Me.txtbxProdName.Location = New System.Drawing.Point(171, 112)
        Me.txtbxProdName.Name = "txtbxProdName"
        Me.txtbxProdName.Size = New System.Drawing.Size(242, 24)
        Me.txtbxProdName.TabIndex = 3
        '
        'txtboxPrice
        '
        Me.txtboxPrice.Location = New System.Drawing.Point(171, 161)
        Me.txtboxPrice.Name = "txtboxPrice"
        Me.txtboxPrice.Size = New System.Drawing.Size(242, 24)
        Me.txtboxPrice.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Price:"
        '
        'txtboxBarCode
        '
        Me.txtboxBarCode.Location = New System.Drawing.Point(171, 206)
        Me.txtboxBarCode.Name = "txtboxBarCode"
        Me.txtboxBarCode.Size = New System.Drawing.Size(242, 24)
        Me.txtboxBarCode.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Barcode:"
        '
        'txtboxDesc
        '
        Me.txtboxDesc.Location = New System.Drawing.Point(171, 307)
        Me.txtboxDesc.Name = "txtboxDesc"
        Me.txtboxDesc.Size = New System.Drawing.Size(242, 77)
        Me.txtboxDesc.TabIndex = 8
        Me.txtboxDesc.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Description:"
        '
        'lblProdId
        '
        Me.lblProdId.AutoSize = True
        Me.lblProdId.Location = New System.Drawing.Point(225, 369)
        Me.lblProdId.Name = "lblProdId"
        Me.lblProdId.Size = New System.Drawing.Size(0, 18)
        Me.lblProdId.TabIndex = 10
        '
        'cboxCategory
        '
        Me.cboxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxCategory.FormattingEnabled = True
        Me.cboxCategory.Location = New System.Drawing.Point(171, 257)
        Me.cboxCategory.Name = "cboxCategory"
        Me.cboxCategory.Size = New System.Drawing.Size(242, 25)
        Me.cboxCategory.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Category:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.IndianRed
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.Snow
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(456, 82)
        Me.Panel1.TabIndex = 14
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = Global.POSwithAndroid.My.Resources.Resources.login_box
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Location = New System.Drawing.Point(-102, -15)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(658, 109)
        Me.Panel5.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(142, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 31)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Product"
        '
        'frmAddProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 464)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboxCategory)
        Me.Controls.Add(Me.lblProdId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtboxDesc)
        Me.Controls.Add(Me.txtboxBarCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtboxPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbxProdName)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei UI Light", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Product"
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtbxProdName As System.Windows.Forms.TextBox
    Friend WithEvents txtboxPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtboxBarCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtboxDesc As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblProdId As System.Windows.Forms.Label
    Friend WithEvents cboxCategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
