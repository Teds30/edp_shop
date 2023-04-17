<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
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
        Me.EmployeeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_AddEmployee = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_EmployeeName = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.Button2.Location = New System.Drawing.Point(485, 107)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 52)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "🔄️Refresh"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(61, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 41)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Employees"
        '
        'dgv_Products
        '
        Me.dgv_Products.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_Products.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Products.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeID, Me.EmployeeName})
        Me.dgv_Products.GridColor = System.Drawing.SystemColors.ControlLight
        Me.dgv_Products.Location = New System.Drawing.Point(69, 166)
        Me.dgv_Products.MultiSelect = False
        Me.dgv_Products.Name = "dgv_Products"
        Me.dgv_Products.RowHeadersWidth = 51
        Me.dgv_Products.RowTemplate.Height = 29
        Me.dgv_Products.Size = New System.Drawing.Size(555, 335)
        Me.dgv_Products.TabIndex = 30
        '
        'EmployeeID
        '
        Me.EmployeeID.HeaderText = "Employee ID"
        Me.EmployeeID.MinimumWidth = 6
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.Width = 125
        '
        'EmployeeName
        '
        Me.EmployeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmployeeName.HeaderText = "Employee Name"
        Me.EmployeeName.MinimumWidth = 6
        Me.EmployeeName.Name = "EmployeeName"
        '
        'btn_AddEmployee
        '
        Me.btn_AddEmployee.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_AddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AddEmployee.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_AddEmployee.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_AddEmployee.Location = New System.Drawing.Point(32, 179)
        Me.btn_AddEmployee.Name = "btn_AddEmployee"
        Me.btn_AddEmployee.Size = New System.Drawing.Size(321, 58)
        Me.btn_AddEmployee.TabIndex = 22
        Me.btn_AddEmployee.Text = "Add Employee"
        Me.btn_AddEmployee.UseVisualStyleBackColor = False
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
        Me.Label1.Text = "Employee Name"
        '
        'txt_EmployeeName
        '
        Me.txt_EmployeeName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_EmployeeName.Location = New System.Drawing.Point(32, 96)
        Me.txt_EmployeeName.Name = "txt_EmployeeName"
        Me.txt_EmployeeName.PlaceholderText = "Enter employee name"
        Me.txt_EmployeeName.Size = New System.Drawing.Size(321, 34)
        Me.txt_EmployeeName.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(25, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 40)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "← Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_AddEmployee)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_EmployeeName)
        Me.GroupBox1.Location = New System.Drawing.Point(731, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 270)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add new Employee"
        '
        'Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1180, 556)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgv_Products)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee"
        CType(Me.dgv_Products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents dgv_Products As DataGridView
    Friend WithEvents btn_AddEmployee As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_EmployeeName As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents EmployeeID As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeName As DataGridViewTextBoxColumn
End Class
