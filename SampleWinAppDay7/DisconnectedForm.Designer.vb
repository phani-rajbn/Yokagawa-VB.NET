<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisconnectedForm
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
        Me.components = New System.ComponentModel.Container()
        Me.btnBranches = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grdBranches = New System.Windows.Forms.DataGridView()
        Me.btnEmployees = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grdEmployees = New System.Windows.Forms.DataGridView()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdBranches, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBranches
        '
        Me.btnBranches.Location = New System.Drawing.Point(12, 12)
        Me.btnBranches.Name = "btnBranches"
        Me.btnBranches.Size = New System.Drawing.Size(198, 71)
        Me.btnBranches.TabIndex = 0
        Me.btnBranches.Text = "Show Branches"
        Me.btnBranches.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grdBranches)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(816, 534)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Branches"
        '
        'grdBranches
        '
        Me.grdBranches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBranches.Location = New System.Drawing.Point(6, 21)
        Me.grdBranches.Name = "grdBranches"
        Me.grdBranches.RowHeadersWidth = 51
        Me.grdBranches.RowTemplate.Height = 24
        Me.grdBranches.Size = New System.Drawing.Size(793, 351)
        Me.grdBranches.TabIndex = 0
        '
        'btnEmployees
        '
        Me.btnEmployees.Location = New System.Drawing.Point(1485, 12)
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Size = New System.Drawing.Size(216, 84)
        Me.btnEmployees.TabIndex = 2
        Me.btnEmployees.Text = "Show Employees"
        Me.btnEmployees.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSort)
        Me.GroupBox2.Controls.Add(Me.grdEmployees)
        Me.GroupBox2.Location = New System.Drawing.Point(856, 102)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(861, 547)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Employees"
        '
        'grdEmployees
        '
        Me.grdEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdEmployees.Location = New System.Drawing.Point(6, 21)
        Me.grdEmployees.Name = "grdEmployees"
        Me.grdEmployees.RowHeadersWidth = 51
        Me.grdEmployees.RowTemplate.Height = 24
        Me.grdEmployees.Size = New System.Drawing.Size(839, 351)
        Me.grdEmployees.TabIndex = 0
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(6, 399)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(226, 82)
        Me.btnSort.TabIndex = 1
        Me.btnSort.Text = "Sort Data"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteRowToolStripMenuItem, Me.UpdateRowToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(211, 84)
        '
        'DeleteRowToolStripMenuItem
        '
        Me.DeleteRowToolStripMenuItem.Name = "DeleteRowToolStripMenuItem"
        Me.DeleteRowToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.DeleteRowToolStripMenuItem.Text = "DeleteRow"
        '
        'UpdateRowToolStripMenuItem
        '
        Me.UpdateRowToolStripMenuItem.Name = "UpdateRowToolStripMenuItem"
        Me.UpdateRowToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.UpdateRowToolStripMenuItem.Text = "UpdateRow"
        '
        'DisconnectedForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1729, 691)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnEmployees)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBranches)
        Me.Name = "DisconnectedForm"
        Me.Text = "DisconnectedForm"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grdBranches, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grdEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBranches As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grdBranches As DataGridView
    Friend WithEvents btnEmployees As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents grdEmployees As DataGridView
    Friend WithEvents btnSort As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteRowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateRowToolStripMenuItem As ToolStripMenuItem
End Class
