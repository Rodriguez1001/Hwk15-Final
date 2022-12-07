<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StuNumber = New System.Windows.Forms.TextBox()
        Me.StuEmail = New System.Windows.Forms.TextBox()
        Me.StuLName = New System.Windows.Forms.TextBox()
        Me.StuFName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnDisplay = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.MediumOrchid
        Me.BtnSave.ForeColor = System.Drawing.Color.LavenderBlush
        Me.BtnSave.Location = New System.Drawing.Point(30, 406)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(120, 41)
        Me.BtnSave.TabIndex = 33
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label5.Location = New System.Drawing.Point(30, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 15)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Student Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label4.Location = New System.Drawing.Point(88, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 15)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label3.Location = New System.Drawing.Point(58, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label2.Location = New System.Drawing.Point(58, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "First Name"
        '
        'StuNumber
        '
        Me.StuNumber.Location = New System.Drawing.Point(125, 313)
        Me.StuNumber.Name = "StuNumber"
        Me.StuNumber.Size = New System.Drawing.Size(100, 23)
        Me.StuNumber.TabIndex = 28
        '
        'StuEmail
        '
        Me.StuEmail.Location = New System.Drawing.Point(125, 251)
        Me.StuEmail.Name = "StuEmail"
        Me.StuEmail.Size = New System.Drawing.Size(100, 23)
        Me.StuEmail.TabIndex = 27
        '
        'StuLName
        '
        Me.StuLName.Location = New System.Drawing.Point(125, 192)
        Me.StuLName.Name = "StuLName"
        Me.StuLName.Size = New System.Drawing.Size(100, 23)
        Me.StuLName.TabIndex = 26
        '
        'StuFName
        '
        Me.StuFName.Location = New System.Drawing.Point(125, 131)
        Me.StuFName.Name = "StuFName"
        Me.StuFName.Size = New System.Drawing.Size(100, 23)
        Me.StuFName.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label1.Location = New System.Drawing.Point(164, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 25)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Student Information"
        '
        'BtnDisplay
        '
        Me.BtnDisplay.BackColor = System.Drawing.Color.MediumOrchid
        Me.BtnDisplay.ForeColor = System.Drawing.Color.LavenderBlush
        Me.BtnDisplay.Location = New System.Drawing.Point(200, 406)
        Me.BtnDisplay.Name = "BtnDisplay"
        Me.BtnDisplay.Size = New System.Drawing.Size(120, 41)
        Me.BtnDisplay.TabIndex = 23
        Me.BtnDisplay.Text = "Display"
        Me.BtnDisplay.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(275, 110)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(205, 199)
        Me.ListBox1.TabIndex = 22
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MediumOrchid
        Me.Button2.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Button2.Location = New System.Drawing.Point(360, 406)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 41)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "DownLoad "
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(515, 567)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StuNumber)
        Me.Controls.Add(Me.StuEmail)
        Me.Controls.Add(Me.StuLName)
        Me.Controls.Add(Me.StuFName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnDisplay)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSave As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents StuNumber As TextBox
    Friend WithEvents StuEmail As TextBox
    Friend WithEvents StuLName As TextBox
    Friend WithEvents StuFName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnDisplay As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
