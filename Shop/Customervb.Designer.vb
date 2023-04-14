<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customervb
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
        Me.btn_AddCustomer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_EmployeeName = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalOrders = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Button2.Location = New System.Drawing.Point(483, 107)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 52)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "🔄️Refresh"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(59, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 41)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Customers"
        '
        'dgv_Products
        '
        Me.dgv_Products.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_Products.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Products.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerID, Me.CustomerName, Me.TotalOrders})
        Me.dgv_Products.GridColor = System.Drawing.SystemColors.ControlLight
        Me.dgv_Products.Location = New System.Drawing.Point(67, 166)
        Me.dgv_Products.MultiSelect = False
        Me.dgv_Products.Name = "dgv_Products"
        Me.dgv_Products.RowHeadersWidth = 51
        Me.dgv_Products.RowTemplate.Height = 29
        Me.dgv_Products.Size = New System.Drawing.Size(555, 335)
        Me.dgv_Products.TabIndex = 35
        '
        'btn_AddCustomer
        '
        Me.btn_AddCustomer.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_AddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AddCustomer.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_AddCustomer.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_AddCustomer.Location = New System.Drawing.Point(32, 179)
        Me.btn_AddCustomer.Name = "btn_AddCustomer"
        Me.btn_AddCustomer.Size = New System.Drawing.Size(321, 58)
        Me.btn_AddCustomer.TabIndex = 22
        Me.btn_AddCustomer.Text = "Add Customer"
        Me.btn_AddCustomer.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(32, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Customer Name"
        '
        'txt_EmployeeName
        '
        Me.txt_EmployeeName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_EmployeeName.Location = New System.Drawing.Point(32, 96)
        Me.txt_EmployeeName.Name = "txt_EmployeeName"
        Me.txt_EmployeeName.PlaceholderText = "Enter customer name"
        Me.txt_EmployeeName.Size = New System.Drawing.Size(321, 34)
        Me.txt_EmployeeName.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(23, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 40)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "← Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_AddCustomer)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_EmployeeName)
        Me.GroupBox1.Location = New System.Drawing.Point(729, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 270)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add new Customer"
        '
        'CustomerID
        '
        Me.CustomerID.HeaderText = "Customer ID"
        Me.CustomerID.MinimumWidth = 6
        Me.CustomerID.Name = "CustomerID"
        Me.CustomerID.Width = 125
        '
        'CustomerName
        '
        Me.CustomerName.HeaderText = "Customer Name"
        Me.CustomerName.MinimumWidth = 6
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.Width = 125
        '
        'TotalOrders
        '
        Me.TotalOrders.HeaderText = "Total Orders"
        Me.TotalOrders.MinimumWidth = 6
        Me.TotalOrders.Name = "TotalOrders"
        Me.TotalOrders.Width = 125
        '
        'Customervb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1247, 625)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgv_Products)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Customervb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customervb"
        CType(Me.dgv_Products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents dgv_Products As DataGridView
    Friend WithEvents btn_AddCustomer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_EmployeeName As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CustomerID As DataGridViewTextBoxColumn
    Friend WithEvents CustomerName As DataGridViewTextBoxColumn
    Friend WithEvents TotalOrders As DataGridViewTextBoxColumn
End Class
