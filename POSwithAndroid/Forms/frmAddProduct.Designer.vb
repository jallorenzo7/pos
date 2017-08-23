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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Name:"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(310, 332)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(108, 48)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(48, 332)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(108, 48)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "&Add Product"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtbxProdName
        '
        Me.txtbxProdName.Location = New System.Drawing.Point(171, 35)
        Me.txtbxProdName.Name = "txtbxProdName"
        Me.txtbxProdName.Size = New System.Drawing.Size(232, 22)
        Me.txtbxProdName.TabIndex = 3
        '
        'txtboxPrice
        '
        Me.txtboxPrice.Location = New System.Drawing.Point(171, 81)
        Me.txtboxPrice.Name = "txtboxPrice"
        Me.txtboxPrice.Size = New System.Drawing.Size(232, 22)
        Me.txtboxPrice.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Price:"
        '
        'txtboxBarCode
        '
        Me.txtboxBarCode.Location = New System.Drawing.Point(171, 123)
        Me.txtboxBarCode.Name = "txtboxBarCode"
        Me.txtboxBarCode.Size = New System.Drawing.Size(232, 22)
        Me.txtboxBarCode.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Barcode:"
        '
        'txtboxDesc
        '
        Me.txtboxDesc.Location = New System.Drawing.Point(171, 218)
        Me.txtboxDesc.Name = "txtboxDesc"
        Me.txtboxDesc.Size = New System.Drawing.Size(232, 73)
        Me.txtboxDesc.TabIndex = 8
        Me.txtboxDesc.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Description:"
        '
        'lblProdId
        '
        Me.lblProdId.AutoSize = True
        Me.lblProdId.Location = New System.Drawing.Point(225, 347)
        Me.lblProdId.Name = "lblProdId"
        Me.lblProdId.Size = New System.Drawing.Size(0, 17)
        Me.lblProdId.TabIndex = 10
        '
        'cboxCategory
        '
        Me.cboxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxCategory.FormattingEnabled = True
        Me.cboxCategory.Location = New System.Drawing.Point(171, 171)
        Me.cboxCategory.Name = "cboxCategory"
        Me.cboxCategory.Size = New System.Drawing.Size(232, 24)
        Me.cboxCategory.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Category:"
        '
        'frmAddProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 410)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAddProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Product"
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
End Class
