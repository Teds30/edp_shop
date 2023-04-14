<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categories
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgv_Products = New System.Windows.Forms.DataGridView()
        Me.btn_AddProduct = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ProdName = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductsCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_Products, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(472, 104)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 52)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "🔄️Refresh"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(48, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 41)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Categories"
        '
        'dgv_Products
        '
        Me.dgv_Products.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_Products.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Products.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Category, Me.ProductsCount, Me.TotalAmount})
        Me.dgv_Products.GridColor = System.Drawing.SystemColors.ControlLight
        Me.dgv_Products.Location = New System.Drawing.Point(56, 163)
        Me.dgv_Products.MultiSelect = False
        Me.dgv_Products.Name = "dgv_Products"
        Me.dgv_Products.RowHeadersWidth = 51
        Me.dgv_Products.RowTemplate.Height = 29
        Me.dgv_Products.Size = New System.Drawing.Size(555, 335)
        Me.dgv_Products.TabIndex = 24
        '
        'btn_AddProduct
        '
        Me.btn_AddProduct.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_AddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AddProduct.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_AddProduct.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_AddProduct.Location = New System.Drawing.Point(32, 179)
        Me.btn_AddProduct.Name = "btn_AddProduct"
        Me.btn_AddProduct.Size = New System.Drawing.Size(321, 58)
        Me.btn_AddProduct.TabIndex = 22
        Me.btn_AddProduct.Text = "Add Category"
        Me.btn_AddProduct.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(32, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Category Name"
        '
        'txt_ProdName
        '
        Me.txt_ProdName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_ProdName.Location = New System.Drawing.Point(32, 96)
        Me.txt_ProdName.Name = "txt_ProdName"
        Me.txt_ProdName.PlaceholderText = "Enter category name"
        Me.txt_ProdName.Size = New System.Drawing.Size(321, 34)
        Me.txt_ProdName.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(12, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 40)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "← Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_AddProduct)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_ProdName)
        Me.GroupBox1.Location = New System.Drawing.Point(718, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 270)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add new Category"
        '
        'Category
        '
        Me.Category.HeaderText = "Category"
        Me.Category.MinimumWidth = 6
        Me.Category.Name = "Category"
        Me.Category.Width = 125
        '
        'ProductsCount
        '
        Me.ProductsCount.HeaderText = "Products Count"
        Me.ProductsCount.MinimumWidth = 6
        Me.ProductsCount.Name = "ProductsCount"
        Me.ProductsCount.Width = 125
        '
        'TotalAmount
        '
        Me.TotalAmount.HeaderText = "Total Amount"
        Me.TotalAmount.MinimumWidth = 6
        Me.TotalAmount.Name = "TotalAmount"
        Me.TotalAmount.Width = 125
        '
        'Categoriesvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 589)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgv_Products)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Categoriesvb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Categoriesvb"
        CType(Me.dgv_Products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents dgv_Products As DataGridView
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents ProductsCount As DataGridViewTextBoxColumn
    Friend WithEvents TotalAmount As DataGridViewTextBoxColumn
    Friend WithEvents btn_AddProduct As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_ProdName As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
