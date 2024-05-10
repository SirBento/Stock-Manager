<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomepageAnderson
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.prodName = New System.Windows.Forms.TextBox()
        Me.prodSellPrice = New System.Windows.Forms.TextBox()
        Me.prodQuantity = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblTotalProducts = New System.Windows.Forms.Label()
        Me.lblTotalReturns = New System.Windows.Forms.Label()
        Me.prodBuyPrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblTotalProfit = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.OldLace
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnSave.FlatAppearance.BorderSize = 5
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Lime
        Me.btnSave.Location = New System.Drawing.Point(525, 94)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(145, 73)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save Product"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(274, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(666, 52)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WELCOME TO HEAVENLY MOBILE"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.OldLace
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderSize = 5
        Me.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(798, 94)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(151, 73)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update Product"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.OldLace
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnDelete.FlatAppearance.BorderSize = 5
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(1067, 90)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(144, 77)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete Product"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1223, 81)
        Me.Panel1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 27)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Product Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 27)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Selling Price ($):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 27)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Quantity:"
        '
        'prodName
        '
        Me.prodName.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prodName.Location = New System.Drawing.Point(199, 103)
        Me.prodName.Name = "prodName"
        Me.prodName.Size = New System.Drawing.Size(265, 30)
        Me.prodName.TabIndex = 9
        '
        'prodSellPrice
        '
        Me.prodSellPrice.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prodSellPrice.Location = New System.Drawing.Point(199, 242)
        Me.prodSellPrice.Name = "prodSellPrice"
        Me.prodSellPrice.Size = New System.Drawing.Size(265, 30)
        Me.prodSellPrice.TabIndex = 11
        '
        'prodQuantity
        '
        Me.prodQuantity.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prodQuantity.Location = New System.Drawing.Point(199, 145)
        Me.prodQuantity.Name = "prodQuantity"
        Me.prodQuantity.Size = New System.Drawing.Size(265, 30)
        Me.prodQuantity.TabIndex = 12
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Linen
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Bradley Hand ITC", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Sienna
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.Linen
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Sienna
        DataGridViewCellStyle12.NullValue = Nothing
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(14, 311)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1197, 290)
        Me.DataGridView1.TabIndex = 13
        '
        'lblTotalProducts
        '
        Me.lblTotalProducts.AutoSize = True
        Me.lblTotalProducts.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalProducts.ForeColor = System.Drawing.Color.Khaki
        Me.lblTotalProducts.Location = New System.Drawing.Point(16, 11)
        Me.lblTotalProducts.Name = "lblTotalProducts"
        Me.lblTotalProducts.Size = New System.Drawing.Size(154, 27)
        Me.lblTotalProducts.TabIndex = 14
        Me.lblTotalProducts.Text = "Total Products:"
        '
        'lblTotalReturns
        '
        Me.lblTotalReturns.AutoSize = True
        Me.lblTotalReturns.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalReturns.ForeColor = System.Drawing.Color.Khaki
        Me.lblTotalReturns.Location = New System.Drawing.Point(352, 11)
        Me.lblTotalReturns.Name = "lblTotalReturns"
        Me.lblTotalReturns.Size = New System.Drawing.Size(210, 27)
        Me.lblTotalReturns.TabIndex = 15
        Me.lblTotalReturns.Text = "Expected Returns($):"
        '
        'prodBuyPrice
        '
        Me.prodBuyPrice.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prodBuyPrice.Location = New System.Drawing.Point(199, 191)
        Me.prodBuyPrice.Name = "prodBuyPrice"
        Me.prodBuyPrice.Size = New System.Drawing.Size(265, 30)
        Me.prodBuyPrice.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 27)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Buying Price ($):"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblTotalCost)
        Me.Panel2.Controls.Add(Me.lblTotalProfit)
        Me.Panel2.Controls.Add(Me.lblTotalReturns)
        Me.Panel2.Controls.Add(Me.lblTotalProducts)
        Me.Panel2.Location = New System.Drawing.Point(525, 205)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(686, 100)
        Me.Panel2.TabIndex = 20
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.ForeColor = System.Drawing.Color.Khaki
        Me.lblTotalCost.Location = New System.Drawing.Point(16, 61)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(134, 27)
        Me.lblTotalCost.TabIndex = 17
        Me.lblTotalCost.Text = "Total Cos($):"
        '
        'lblTotalProfit
        '
        Me.lblTotalProfit.AutoSize = True
        Me.lblTotalProfit.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalProfit.ForeColor = System.Drawing.Color.Khaki
        Me.lblTotalProfit.Location = New System.Drawing.Point(352, 61)
        Me.lblTotalProfit.Name = "lblTotalProfit"
        Me.lblTotalProfit.Size = New System.Drawing.Size(193, 27)
        Me.lblTotalProfit.TabIndex = 16
        Me.lblTotalProfit.Text = "Expected Profit($):"
        '
        'HomepageAnderson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(1223, 613)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.prodBuyPrice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.prodQuantity)
        Me.Controls.Add(Me.prodSellPrice)
        Me.Controls.Add(Me.prodName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "HomepageAnderson"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents prodName As TextBox
    Friend WithEvents prodSellPrice As TextBox
    Friend WithEvents prodQuantity As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblTotalProducts As Label
    Friend WithEvents lblTotalReturns As Label
    Friend WithEvents prodBuyPrice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTotalProfit As Label
    Friend WithEvents lblTotalCost As Label
End Class
