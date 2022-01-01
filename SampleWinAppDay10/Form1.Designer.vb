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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.openFileDlg = New System.Windows.Forms.OpenFileDialog()
        Me.lstClasses = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstFunctions = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstParameters = New System.Windows.Forms.ListBox()
        Me.btnInvoke = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(477, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(535, 78)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Display Class info"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 36)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select the DLL:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(231, 139)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1277, 43)
        Me.TextBox1.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(1514, 139)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(42, 43)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = ".."
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lstClasses
        '
        Me.lstClasses.FormattingEnabled = True
        Me.lstClasses.ItemHeight = 35
        Me.lstClasses.Location = New System.Drawing.Point(33, 262)
        Me.lstClasses.Name = "lstClasses"
        Me.lstClasses.Size = New System.Drawing.Size(442, 389)
        Me.lstClasses.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 36)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "List of classes:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(535, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(231, 36)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "List of Functions"
        '
        'lstFunctions
        '
        Me.lstFunctions.FormattingEnabled = True
        Me.lstFunctions.ItemHeight = 35
        Me.lstFunctions.Location = New System.Drawing.Point(541, 262)
        Me.lstFunctions.Name = "lstFunctions"
        Me.lstFunctions.Size = New System.Drawing.Size(442, 389)
        Me.lstFunctions.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1018, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(253, 36)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "List of Parameters"
        '
        'lstParameters
        '
        Me.lstParameters.FormattingEnabled = True
        Me.lstParameters.ItemHeight = 35
        Me.lstParameters.Location = New System.Drawing.Point(1024, 263)
        Me.lstParameters.Name = "lstParameters"
        Me.lstParameters.Size = New System.Drawing.Size(403, 389)
        Me.lstParameters.TabIndex = 9
        '
        'btnInvoke
        '
        Me.btnInvoke.Location = New System.Drawing.Point(1024, 668)
        Me.btnInvoke.Name = "btnInvoke"
        Me.btnInvoke.Size = New System.Drawing.Size(403, 64)
        Me.btnInvoke.TabIndex = 10
        Me.btnInvoke.Text = "Invoke Function"
        Me.btnInvoke.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 35.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1737, 744)
        Me.Controls.Add(Me.btnInvoke)
        Me.Controls.Add(Me.lstParameters)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lstFunctions)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstClasses)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "Form1"
        Me.Text = "ReflectionExample"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents openFileDlg As OpenFileDialog
    Friend WithEvents lstClasses As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lstFunctions As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lstParameters As ListBox
    Friend WithEvents btnInvoke As Button
End Class
