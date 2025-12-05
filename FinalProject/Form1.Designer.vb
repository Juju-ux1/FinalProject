<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.lblDept = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dgvEmployees = New System.Windows.Forms.DataGridView()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(44, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(466, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "EMPLOYEE RECORDS SYSTEM"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblID.Font = New System.Drawing.Font("NSimSun", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(41, 95)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(103, 15)
        Me.lblID.TabIndex = 1
        Me.lblID.Text = "Employee ID:"
        Me.lblID.Visible = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblName.Font = New System.Drawing.Font("NSimSun", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(41, 133)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(47, 15)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name:"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblPosition.Font = New System.Drawing.Font("NSimSun", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.Location = New System.Drawing.Point(41, 173)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(79, 15)
        Me.lblPosition.TabIndex = 3
        Me.lblPosition.Text = "Position:"
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = True
        Me.lblSalary.BackColor = System.Drawing.Color.Silver
        Me.lblSalary.Font = New System.Drawing.Font("NSimSun", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalary.Location = New System.Drawing.Point(41, 212)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(63, 15)
        Me.lblSalary.TabIndex = 4
        Me.lblSalary.Text = "Salary:"
        '
        'lblDept
        '
        Me.lblDept.AutoSize = True
        Me.lblDept.BackColor = System.Drawing.Color.Silver
        Me.lblDept.Font = New System.Drawing.Font("NSimSun", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDept.Location = New System.Drawing.Point(41, 247)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(95, 15)
        Me.lblDept.TabIndex = 5
        Me.lblDept.Text = "Department:"
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.SystemColors.Menu
        Me.txtID.Location = New System.Drawing.Point(183, 90)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(240, 20)
        Me.txtID.TabIndex = 6
        Me.txtID.Visible = False
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Menu
        Me.txtName.Location = New System.Drawing.Point(183, 133)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(240, 20)
        Me.txtName.TabIndex = 7
        '
        'txtPosition
        '
        Me.txtPosition.BackColor = System.Drawing.SystemColors.Menu
        Me.txtPosition.Location = New System.Drawing.Point(183, 173)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(240, 20)
        Me.txtPosition.TabIndex = 8
        '
        'txtSalary
        '
        Me.txtSalary.BackColor = System.Drawing.SystemColors.Menu
        Me.txtSalary.Location = New System.Drawing.Point(183, 212)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(240, 20)
        Me.txtSalary.TabIndex = 9
        '
        'txtDepartment
        '
        Me.txtDepartment.BackColor = System.Drawing.SystemColors.Menu
        Me.txtDepartment.Location = New System.Drawing.Point(183, 247)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(240, 20)
        Me.txtDepartment.TabIndex = 10
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnCreate.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnCreate.Location = New System.Drawing.Point(44, 296)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(88, 32)
        Me.btnCreate.TabIndex = 11
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'btnRead
        '
        Me.btnRead.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnRead.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnRead.Location = New System.Drawing.Point(146, 296)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(88, 32)
        Me.btnRead.TabIndex = 12
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnUpdate.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnUpdate.Location = New System.Drawing.Point(240, 296)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(88, 32)
        Me.btnUpdate.TabIndex = 13
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnDelete.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnDelete.Location = New System.Drawing.Point(335, 296)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(88, 32)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnClear.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnClear.Location = New System.Drawing.Point(432, 296)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(88, 32)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'dgvEmployees
        '
        Me.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmployees.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployees.Location = New System.Drawing.Point(12, 346)
        Me.dgvEmployees.Name = "dgvEmployees"
        Me.dgvEmployees.ReadOnly = True
        Me.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmployees.Size = New System.Drawing.Size(543, 248)
        Me.dgvEmployees.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FinalProject.My.Resources.Resources.Fundo_de_escritório_desfocado_escritório_desfocado_para_fundo_de_apresentação___imagem_Premium_gerada_com_IA
        Me.ClientSize = New System.Drawing.Size(580, 606)
        Me.Controls.Add(Me.dgvEmployees)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.txtDepartment)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblDept)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lblID As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents lblDept As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvEmployees As DataGridView
End Class
