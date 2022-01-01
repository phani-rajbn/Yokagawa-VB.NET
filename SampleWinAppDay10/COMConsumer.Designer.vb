<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COMConsumer
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.subFunc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(269, 105)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(202, 75)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add Func"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'subFunc
        '
        Me.subFunc.Location = New System.Drawing.Point(269, 206)
        Me.subFunc.Name = "subFunc"
        Me.subFunc.Size = New System.Drawing.Size(202, 75)
        Me.subFunc.TabIndex = 1
        Me.subFunc.Text = "Subtract"
        Me.subFunc.UseVisualStyleBackColor = True
        '
        'COMConsumer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.subFunc)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "COMConsumer"
        Me.Text = "COMConsumer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents subFunc As Button
End Class
