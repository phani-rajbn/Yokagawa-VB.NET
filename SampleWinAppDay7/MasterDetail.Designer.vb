<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterDetail
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
        Me.lstNames = New System.Windows.Forms.ListBox()
        Me.grDetails = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnFetch = New System.Windows.Forms.Button()
        Me.grDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(471, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(584, 78)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Master Detail Form"
        '
        'lstNames
        '
        Me.lstNames.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstNames.FormattingEnabled = True
        Me.lstNames.ItemHeight = 35
        Me.lstNames.Location = New System.Drawing.Point(81, 188)
        Me.lstNames.Name = "lstNames"
        Me.lstNames.Size = New System.Drawing.Size(294, 494)
        Me.lstNames.TabIndex = 2
        '
        'grDetails
        '
        Me.grDetails.Controls.Add(Me.btnUpdate)
        Me.grDetails.Controls.Add(Me.txtSalary)
        Me.grDetails.Controls.Add(Me.txtAddress)
        Me.grDetails.Controls.Add(Me.txtName)
        Me.grDetails.Controls.Add(Me.txtID)
        Me.grDetails.Controls.Add(Me.Label6)
        Me.grDetails.Controls.Add(Me.Label5)
        Me.grDetails.Controls.Add(Me.Label4)
        Me.grDetails.Controls.Add(Me.Label3)
        Me.grDetails.Location = New System.Drawing.Point(597, 169)
        Me.grDetails.Name = "grDetails"
        Me.grDetails.Size = New System.Drawing.Size(665, 471)
        Me.grDetails.TabIndex = 3
        Me.grDetails.TabStop = False
        Me.grDetails.Text = "Employee Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(174, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 39)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(120, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 39)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 39)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Address:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(120, 304)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 39)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Salary:"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(253, 61)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(355, 46)
        Me.txtID.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(253, 144)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(355, 46)
        Me.txtName.TabIndex = 5
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(253, 224)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(355, 46)
        Me.txtAddress.TabIndex = 6
        '
        'txtSalary
        '
        Me.txtSalary.Enabled = False
        Me.txtSalary.Location = New System.Drawing.Point(253, 301)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(355, 46)
        Me.txtSalary.TabIndex = 7
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(421, 386)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(187, 55)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnFetch
        '
        Me.btnFetch.Location = New System.Drawing.Point(81, 119)
        Me.btnFetch.Name = "btnFetch"
        Me.btnFetch.Size = New System.Drawing.Size(294, 63)
        Me.btnFetch.TabIndex = 4
        Me.btnFetch.Text = "Fetch Employees"
        Me.btnFetch.UseVisualStyleBackColor = True
        '
        'MasterDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(18.0!, 39.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1419, 728)
        Me.Controls.Add(Me.btnFetch)
        Me.Controls.Add(Me.grDetails)
        Me.Controls.Add(Me.lstNames)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Green
        Me.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.Name = "MasterDetail"
        Me.Text = "MasterDetail"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grDetails.ResumeLayout(False)
        Me.grDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstNames As ListBox
    Friend WithEvents grDetails As GroupBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnFetch As Button
End Class
