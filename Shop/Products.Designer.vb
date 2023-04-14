<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Products
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_ProdName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_ProdStocks = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_ProdPrice = New System.Windows.Forms.TextBox()
        Me.btn_AddProduct = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgv_Products = New System.Windows.Forms.DataGridView()
        Me.Product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stocks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_ProdCat = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgv_Products, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "← Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_ProdName
        '
        Me.txt_ProdName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_ProdName.Location = New System.Drawing.Point(750, 199)
        Me.txt_ProdName.Name = "txt_ProdName"
        Me.txt_ProdName.PlaceholderText = "Enter product's name"
        Me.txt_ProdName.Size = New System.Drawing.Size(321, 34)
        Me.txt_ProdName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(750, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Product Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(750, 251)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Stocks"
        '
        'txt_ProdStocks
        '
        Me.txt_ProdStocks.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_ProdStocks.Location = New System.Drawing.Point(750, 285)
        Me.txt_ProdStocks.Name = "txt_ProdStocks"
        Me.txt_ProdStocks.PlaceholderText = "Enter product's stocks"
        Me.txt_ProdStocks.Size = New System.Drawing.Size(321, 34)
        Me.txt_ProdStocks.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(750, 337)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Price"
        '
        'txt_ProdPrice
        '
        Me.txt_ProdPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_ProdPrice.Location = New System.Drawing.Point(750, 371)
        Me.txt_ProdPrice.Name = "txt_ProdPrice"
        Me.txt_ProdPrice.PlaceholderText = "Enter product's price"
        Me.txt_ProdPrice.Size = New System.Drawing.Size(206, 34)
        Me.txt_ProdPrice.TabIndex = 5
        '
        'btn_AddProduct
        '
        Me.btn_AddProduct.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_AddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AddProduct.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_AddProduct.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_AddProduct.Location = New System.Drawing.Point(750, 427)
        Me.btn_AddProduct.Name = "btn_AddProduct"
        Me.btn_AddProduct.Size = New System.Drawing.Size(206, 58)
        Me.btn_AddProduct.TabIndex = 7
        Me.btn_AddProduct.Text = "Add Product"
        Me.btn_AddProduct.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(750, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Category"
        '
        'dgv_Products
        '
        Me.dgv_Products.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_Products.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Products.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Product, Me.Price, Me.Stocks, Me.Category})
        Me.dgv_Products.GridColor = System.Drawing.SystemColors.ControlLight
        Me.dgv_Products.Location = New System.Drawing.Point(56, 150)
        Me.dgv_Products.MultiSelect = False
        Me.dgv_Products.Name = "dgv_Products"
        Me.dgv_Products.RowHeadersWidth = 51
        Me.dgv_Products.RowTemplate.Height = 29
        Me.dgv_Products.Size = New System.Drawing.Size(555, 335)
        Me.dgv_Products.TabIndex = 10
        '
        'Product
        '
        Me.Product.HeaderText = "Product"
        Me.Product.MinimumWidth = 6
        Me.Product.Name = "Product"
        Me.Product.Width = 125
        '
        'Price
        '
        Me.Price.HeaderText = "Price"
        Me.Price.MinimumWidth = 6
        Me.Price.Name = "Price"
        Me.Price.Width = 125
        '
        'Stocks
        '
        Me.Stocks.HeaderText = "Stocks"
        Me.Stocks.MinimumWidth = 6
        Me.Stocks.Name = "Stocks"
        Me.Stocks.Width = 125
        '
        'Category
        '
        Me.Category.HeaderText = "Category"
        Me.Category.MinimumWidth = 6
        Me.Category.Name = "Category"
        Me.Category.Width = 125
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(48, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 41)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Products"
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(472, 91)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 52)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "🔄️Refresh"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txt_ProdCat
        '
        Me.txt_ProdCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_ProdCat.FormattingEnabled = True
        Me.txt_ProdCat.Location = New System.Drawing.Point(750, 116)
        Me.txt_ProdCat.Name = "txt_ProdCat"
        Me.txt_ProdCat.Size = New System.Drawing.Size(151, 28)
        Me.txt_ProdCat.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(718, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 457)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List Prooduct"
        '
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1172, 526)
        Me.Controls.Add(Me.txt_ProdCat)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgv_Products)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_AddProduct)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_ProdPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_ProdStocks)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_ProdName)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Products"
        Me.Text = "Products"
        CType(Me.dgv_Products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txt_ProdName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_ProdStocks As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_ProdPrice As TextBox
    Friend WithEvents btn_AddProduct As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents dgv_Products As DataGridView
    Friend WithEvents Product As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Stocks As DataGridViewTextBoxColumn
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents txt_ProdCat As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
