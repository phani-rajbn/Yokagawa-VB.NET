<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisconnectedInsert
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
        Me.empDetails = New SampleWinAppDay7.Employee()
        Me.SuspendLayout()
        '
        'empDetails
        '
        Me.empDetails.EmpIDEnabled = True
        Me.empDetails.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empDetails.Location = New System.Drawing.Point(344, 67)
        Me.empDetails.Margin = New System.Windows.Forms.Padding(6)
        Me.empDetails.Name = "empDetails"
        Me.empDetails.Size = New System.Drawing.Size(918, 547)
        Me.empDetails.TabIndex = 0
        '
        'DisconnectedInsert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 36.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1747, 715)
        Me.Controls.Add(Me.empDetails)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "DisconnectedInsert"
        Me.Text = "DisconnectedInsert"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents empDetails As Employee
End Class
