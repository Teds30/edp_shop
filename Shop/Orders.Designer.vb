<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Orders
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
        Me.txt_ProdCat = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgv_Orders = New System.Windows.Forms.DataGridView()
        Me.OrderID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Customer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Employee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_AddProduct = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_OrdQuantity = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.dgv_Orders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_ProdCat
        '
        Me.txt_ProdCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt_ProdCat.FormattingEnabled = True
        Me.txt_ProdCat.Location = New System.Drawing.Point(32, 82)
        Me.txt_ProdCat.Name = "txt_ProdCat"
        Me.txt_ProdCat.Size = New System.Drawing.Size(321, 39)
        Me.txt_ProdCat.TabIndex = 27
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(573, 91)
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
        Me.Label5.Location = New System.Drawing.Point(48, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 41)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Orders"
        '
        'dgv_Orders
        '
        Me.dgv_Orders.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_Orders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Orders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderID, Me.Customer, Me.Employee, Me.ProductName, Me.ProductQuantity})
        Me.dgv_Orders.GridColor = System.Drawing.SystemColors.ControlLight
        Me.dgv_Orders.Location = New System.Drawing.Point(56, 150)
        Me.dgv_Orders.MultiSelect = False
        Me.dgv_Orders.Name = "dgv_Orders"
        Me.dgv_Orders.RowHeadersWidth = 51
        Me.dgv_Orders.RowTemplate.Height = 29
        Me.dgv_Orders.Size = New System.Drawing.Size(656, 335)
        Me.dgv_Orders.TabIndex = 24
        '
        'OrderID
        '
        Me.OrderID.HeaderText = "Order ID"
        Me.OrderID.MinimumWidth = 6
        Me.OrderID.Name = "OrderID"
        Me.OrderID.Width = 125
        '
        'Customer
        '
        Me.Customer.HeaderText = "Customer"
        Me.Customer.MinimumWidth = 6
        Me.Customer.Name = "Customer"
        Me.Customer.Width = 125
        '
        'Employee
        '
        Me.Employee.HeaderText = "Employee"
        Me.Employee.MinimumWidth = 6
        Me.Employee.Name = "Employee"
        Me.Employee.Width = 125
        '
        'ProductName
        '
        Me.ProductName.HeaderText = "Product Name"
        Me.ProductName.MinimumWidth = 6
        Me.ProductName.Name = "ProductName"
        Me.ProductName.Width = 125
        '
        'ProductQuantity
        '
        Me.ProductQuantity.HeaderText = "Quantity"
        Me.ProductQuantity.MinimumWidth = 6
        Me.ProductQuantity.Name = "ProductQuantity"
        Me.ProductQuantity.Width = 125
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(32, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Category"
        '
        'btn_AddProduct
        '
        Me.btn_AddProduct.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_AddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AddProduct.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_AddProduct.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_AddProduct.Location = New System.Drawing.Point(32, 377)
        Me.btn_AddProduct.Name = "btn_AddProduct"
        Me.btn_AddProduct.Size = New System.Drawing.Size(321, 58)
        Me.btn_AddProduct.TabIndex = 22
        Me.btn_AddProduct.Text = "Place Order"
        Me.btn_AddProduct.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(32, 328)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Total Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(32, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Quantity"
        '
        'txt_OrdQuantity
        '
        Me.txt_OrdQuantity.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_OrdQuantity.Location = New System.Drawing.Point(32, 251)
        Me.txt_OrdQuantity.Name = "txt_OrdQuantity"
        Me.txt_OrdQuantity.PlaceholderText = "Enter Quantity"
        Me.txt_OrdQuantity.Size = New System.Drawing.Size(321, 34)
        Me.txt_OrdQuantity.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(32, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Products"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 40)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "← Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_ProdCat)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_AddProduct)
        Me.GroupBox1.Controls.Add(Me.txt_OrdQuantity)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(758, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 472)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "New Order"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(294, 319)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 31)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "0.00"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(32, 155)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(321, 39)
        Me.ComboBox1.TabIndex = 29
        '
        'Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 586)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgv_Orders)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Orders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orders"
        CType(Me.dgv_Orders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_ProdCat As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents dgv_Orders As DataGridView
    Friend WithEvents OrderID As DataGridViewTextBoxColumn
    Friend WithEvents Customer As DataGridViewTextBoxColumn
    Friend WithEvents Employee As DataGridViewTextBoxColumn
    Friend WithEvents ProductName As DataGridViewTextBoxColumn
    Friend WithEvents ProductQuantity As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_AddProduct As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_OrdQuantity As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
