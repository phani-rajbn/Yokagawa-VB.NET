<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MasterDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterDetail))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstNames = New System.Windows.Forms.ListBox()
        Me.btnFetch = New System.Windows.Forms.Button()
        Me.mnuList = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.EmpDetails = New SampleWinAppDay7.Employee()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.mnuList.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(470, 35)
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
        'btnFetch
        '
        Me.btnFetch.Location = New System.Drawing.Point(81, 119)
        Me.btnFetch.Name = "btnFetch"
        Me.btnFetch.Size = New System.Drawing.Size(294, 63)
        Me.btnFetch.TabIndex = 4
        Me.btnFetch.Text = "Fetch Employees"
        Me.btnFetch.UseVisualStyleBackColor = True
        '
        'mnuList
        '
        Me.mnuList.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.mnuList.Location = New System.Drawing.Point(0, 0)
        Me.mnuList.Name = "mnuList"
        Me.mnuList.Size = New System.Drawing.Size(1419, 30)
        Me.mnuList.TabIndex = 5
        Me.mnuList.Text = "MenuStrip1"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewEmployeeToolStripMenuItem, Me.DeleteEmployeeToolStripMenuItem, Me.TreeViewToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(87, 26)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'AddNewEmployeeToolStripMenuItem
        '
        Me.AddNewEmployeeToolStripMenuItem.Name = "AddNewEmployeeToolStripMenuItem"
        Me.AddNewEmployeeToolStripMenuItem.Size = New System.Drawing.Size(238, 26)
        Me.AddNewEmployeeToolStripMenuItem.Text = "Add New Employee"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(235, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(238, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'DeleteEmployeeToolStripMenuItem
        '
        Me.DeleteEmployeeToolStripMenuItem.Name = "DeleteEmployeeToolStripMenuItem"
        Me.DeleteEmployeeToolStripMenuItem.Size = New System.Drawing.Size(238, 26)
        Me.DeleteEmployeeToolStripMenuItem.Text = "DeleteEmployee"
        '
        'TreeViewToolStripMenuItem
        '
        Me.TreeViewToolStripMenuItem.Name = "TreeViewToolStripMenuItem"
        Me.TreeViewToolStripMenuItem.Size = New System.Drawing.Size(238, 26)
        Me.TreeViewToolStripMenuItem.Text = "TreeView"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 30)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1419, 27)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'EmpDetails
        '
        Me.EmpDetails.EmpIDEnabled = False
        Me.EmpDetails.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpDetails.Location = New System.Drawing.Point(454, 119)
        Me.EmpDetails.Margin = New System.Windows.Forms.Padding(6)
        Me.EmpDetails.Name = "EmpDetails"
        Me.EmpDetails.Size = New System.Drawing.Size(924, 530)
        Me.EmpDetails.TabIndex = 6
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'MasterDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(18.0!, 39.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1419, 728)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.EmpDetails)
        Me.Controls.Add(Me.btnFetch)
        Me.Controls.Add(Me.lstNames)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mnuList)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Green
        Me.MainMenuStrip = Me.mnuList
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.Name = "MasterDetail"
        Me.Text = "MasterDetail"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuList.ResumeLayout(False)
        Me.mnuList.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstNames As ListBox
    Friend WithEvents btnFetch As Button
    Friend WithEvents mnuList As MenuStrip
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpDetails As Employee
    Friend WithEvents DeleteEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TreeViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
