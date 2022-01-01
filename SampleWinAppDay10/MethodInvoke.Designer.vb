<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MethodInvoke
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnInvoke = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft YaHei", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, -2)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(489, 80)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Method Name:"
        '
        'btnInvoke
        '
        Me.btnInvoke.Location = New System.Drawing.Point(1431, 589)
        Me.btnInvoke.Name = "btnInvoke"
        Me.btnInvoke.Size = New System.Drawing.Size(183, 74)
        Me.btnInvoke.TabIndex = 1
        Me.btnInvoke.Text = "Get Result"
        Me.btnInvoke.UseVisualStyleBackColor = True
        '
        'MethodInvoke
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 35.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1649, 675)
        Me.Controls.Add(Me.btnInvoke)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "MethodInvoke"
        Me.Text = "MethodInvoke"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnInvoke As Button
End Class
