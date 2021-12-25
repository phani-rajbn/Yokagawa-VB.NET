<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewEmployee
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
        Me.Employee1 = New SampleWinAppDay7.Employee()
        Me.SuspendLayout()
        '
        'Employee1
        '
        Me.Employee1.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Employee1.Location = New System.Drawing.Point(139, 33)
        Me.Employee1.Margin = New System.Windows.Forms.Padding(6)
        Me.Employee1.Name = "Employee1"
        Me.Employee1.Size = New System.Drawing.Size(1046, 653)
        Me.Employee1.TabIndex = 0
        '
        'NewEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1322, 772)
        Me.Controls.Add(Me.Employee1)
        Me.Name = "NewEmployee"
        Me.Text = "NewEmployee"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Employee1 As Employee
End Class
