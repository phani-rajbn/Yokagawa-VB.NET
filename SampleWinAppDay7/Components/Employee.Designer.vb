<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(248, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(486, 77)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(148, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Employee ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(98, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(242, 38)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Employee Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(70, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(270, 38)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Employee Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(99, 362)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(241, 38)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Employee Salary:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(346, 137)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(388, 42)
        Me.txtID.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtID, "ID of the Employee")
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(346, 208)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(388, 42)
        Me.txtName.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txtName, "Name of the Employee")
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(346, 287)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(388, 42)
        Me.txtAddress.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.txtAddress, "Address of the Employee")
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(346, 358)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(388, 42)
        Me.txtSalary.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.txtSalary, "Salary of the Employee")
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(261, 430)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(215, 76)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.ToolTip1.SetToolTip(Me.btnSave, "Click to Submit")
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 10
        Me.ToolTip1.ReshowDelay = 100
        '
        'Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 34.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "Employee"
        Me.Size = New System.Drawing.Size(828, 547)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
