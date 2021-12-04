<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UIForm
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtUpdatePrice = New System.Windows.Forms.TextBox()
        Me.txtUpdateAuthor = New System.Windows.Forms.TextBox()
        Me.txtUpdateTitle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnUpdateFind = New System.Windows.Forms.Button()
        Me.lblUpdateId = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Consolas", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(422, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(499, 43)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Book Management Software"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.txtAuthor)
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 324)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add New Book"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Book Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Book Author"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Book Price"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(187, 46)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(207, 32)
        Me.txtTitle.TabIndex = 4
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(187, 93)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(207, 32)
        Me.txtAuthor.TabIndex = 5
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(187, 145)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(207, 32)
        Me.txtPrice.TabIndex = 6
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(114, 223)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(207, 67)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save Details"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.lblUpdateId)
        Me.GroupBox2.Controls.Add(Me.btnUpdateFind)
        Me.GroupBox2.Controls.Add(Me.btnUpdate)
        Me.GroupBox2.Controls.Add(Me.txtUpdatePrice)
        Me.GroupBox2.Controls.Add(Me.txtUpdateAuthor)
        Me.GroupBox2.Controls.Add(Me.txtUpdateTitle)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(592, 82)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(445, 324)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Update Book"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(193, 236)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(207, 67)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtUpdatePrice
        '
        Me.txtUpdatePrice.Location = New System.Drawing.Point(193, 185)
        Me.txtUpdatePrice.Name = "txtUpdatePrice"
        Me.txtUpdatePrice.Size = New System.Drawing.Size(207, 32)
        Me.txtUpdatePrice.TabIndex = 6
        '
        'txtUpdateAuthor
        '
        Me.txtUpdateAuthor.Location = New System.Drawing.Point(193, 133)
        Me.txtUpdateAuthor.Name = "txtUpdateAuthor"
        Me.txtUpdateAuthor.Size = New System.Drawing.Size(207, 32)
        Me.txtUpdateAuthor.TabIndex = 5
        '
        'txtUpdateTitle
        '
        Me.txtUpdateTitle.Location = New System.Drawing.Point(193, 86)
        Me.txtUpdateTitle.Name = "txtUpdateTitle"
        Me.txtUpdateTitle.Size = New System.Drawing.Size(207, 32)
        Me.txtUpdateTitle.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Book Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 24)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Book Author"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 24)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Book Title"
        '
        'btnUpdateFind
        '
        Me.btnUpdateFind.Location = New System.Drawing.Point(24, 37)
        Me.btnUpdateFind.Name = "btnUpdateFind"
        Me.btnUpdateFind.Size = New System.Drawing.Size(151, 41)
        Me.btnUpdateFind.TabIndex = 8
        Me.btnUpdateFind.Text = "Find"
        Me.btnUpdateFind.UseVisualStyleBackColor = True
        '
        'lblUpdateId
        '
        Me.lblUpdateId.AutoSize = True
        Me.lblUpdateId.Location = New System.Drawing.Point(219, 46)
        Me.lblUpdateId.Name = "lblUpdateId"
        Me.lblUpdateId.Size = New System.Drawing.Size(0, 24)
        Me.lblUpdateId.TabIndex = 9
        '
        'UIForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1408, 595)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "UIForm"
        Me.Text = "UIForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Windows.Forms.Label
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents btnSave As Windows.Forms.Button
    Friend WithEvents txtPrice As Windows.Forms.TextBox
    Friend WithEvents txtAuthor As Windows.Forms.TextBox
    Friend WithEvents txtTitle As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents btnUpdateFind As Windows.Forms.Button
    Friend WithEvents btnUpdate As Windows.Forms.Button
    Friend WithEvents txtUpdatePrice As Windows.Forms.TextBox
    Friend WithEvents txtUpdateAuthor As Windows.Forms.TextBox
    Friend WithEvents txtUpdateTitle As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents lblUpdateId As Windows.Forms.Label
End Class
