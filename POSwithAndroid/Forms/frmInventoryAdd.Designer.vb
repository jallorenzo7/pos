<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryAdd
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtbxTransactionId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBoxQuantity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtboxCost = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtdateTime = New System.Windows.Forms.DateTimePicker()
        Me.cboxProduct = New System.Windows.Forms.ComboBox()
        Me.lblStockId = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(322, 238)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(116, 32)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtbxTransactionId
        '
        Me.txtbxTransactionId.Location = New System.Drawing.Point(147, 29)
        Me.txtbxTransactionId.Name = "txtbxTransactionId"
        Me.txtbxTransactionId.Size = New System.Drawing.Size(271, 22)
        Me.txtbxTransactionId.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Transaction ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Quantity"
        '
        'txtBoxQuantity
        '
        Me.txtBoxQuantity.Location = New System.Drawing.Point(147, 108)
        Me.txtBoxQuantity.Name = "txtBoxQuantity"
        Me.txtBoxQuantity.Size = New System.Drawing.Size(271, 22)
        Me.txtBoxQuantity.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Product:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Date of Arrival:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Cost:"
        '
        'txtboxCost
        '
        Me.txtboxCost.Location = New System.Drawing.Point(147, 193)
        Me.txtboxCost.Name = "txtboxCost"
        Me.txtboxCost.Size = New System.Drawing.Size(271, 22)
        Me.txtboxCost.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(30, 238)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(116, 32)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "&Add Inventory"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtdateTime
        '
        Me.txtdateTime.Location = New System.Drawing.Point(147, 147)
        Me.txtdateTime.Name = "txtdateTime"
        Me.txtdateTime.Size = New System.Drawing.Size(271, 22)
        Me.txtdateTime.TabIndex = 4
        '
        'cboxProduct
        '
        Me.cboxProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxProduct.FormattingEnabled = True
        Me.cboxProduct.Location = New System.Drawing.Point(147, 68)
        Me.cboxProduct.Name = "cboxProduct"
        Me.cboxProduct.Size = New System.Drawing.Size(271, 24)
        Me.cboxProduct.TabIndex = 12
        '
        'lblStockId
        '
        Me.lblStockId.AutoSize = True
        Me.lblStockId.Location = New System.Drawing.Point(225, 252)
        Me.lblStockId.Name = "lblStockId"
        Me.lblStockId.Size = New System.Drawing.Size(0, 17)
        Me.lblStockId.TabIndex = 13
        '
        'frmInventoryAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 302)
        Me.Controls.Add(Me.lblStockId)
        Me.Controls.Add(Me.cboxProduct)
        Me.Controls.Add(Me.txtdateTime)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtboxCost)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBoxQuantity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbxTransactionId)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmInventoryAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Adding"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtbxTransactionId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBoxQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtboxCost As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtdateTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboxProduct As System.Windows.Forms.ComboBox
    Friend WithEvents lblStockId As System.Windows.Forms.Label
End Class
