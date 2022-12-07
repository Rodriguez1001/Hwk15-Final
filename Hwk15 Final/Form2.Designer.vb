<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.CourseNum = New System.Windows.Forms.TextBox()
        Me.CourseNam = New System.Windows.Forms.TextBox()
        Me.CourseUnits = New System.Windows.Forms.TextBox()
        Me.CourseRmNum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnDisplay = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.MistyRose
        Me.Label1.Location = New System.Drawing.Point(165, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Course Information"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(277, 106)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(205, 199)
        Me.ListBox1.TabIndex = 1
        '
        'CourseNum
        '
        Me.CourseNum.Location = New System.Drawing.Point(123, 127)
        Me.CourseNum.Name = "CourseNum"
        Me.CourseNum.Size = New System.Drawing.Size(100, 23)
        Me.CourseNum.TabIndex = 2
        '
        'CourseNam
        '
        Me.CourseNam.Location = New System.Drawing.Point(123, 188)
        Me.CourseNam.Name = "CourseNam"
        Me.CourseNam.Size = New System.Drawing.Size(100, 23)
        Me.CourseNam.TabIndex = 3
        '
        'CourseUnits
        '
        Me.CourseUnits.Location = New System.Drawing.Point(123, 247)
        Me.CourseUnits.Name = "CourseUnits"
        Me.CourseUnits.Size = New System.Drawing.Size(100, 23)
        Me.CourseUnits.TabIndex = 4
        '
        'CourseRmNum
        '
        Me.CourseRmNum.Location = New System.Drawing.Point(123, 309)
        Me.CourseRmNum.Name = "CourseRmNum"
        Me.CourseRmNum.Size = New System.Drawing.Size(100, 23)
        Me.CourseRmNum.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.MistyRose
        Me.Label2.Location = New System.Drawing.Point(30, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Course Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.MistyRose
        Me.Label3.Location = New System.Drawing.Point(42, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Course Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.MistyRose
        Me.Label4.Location = New System.Drawing.Point(86, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Units"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.MistyRose
        Me.Label5.Location = New System.Drawing.Point(36, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Room Number"
        '
        'BtnDisplay
        '
        Me.BtnDisplay.BackColor = System.Drawing.Color.IndianRed
        Me.BtnDisplay.ForeColor = System.Drawing.Color.Snow
        Me.BtnDisplay.Location = New System.Drawing.Point(208, 407)
        Me.BtnDisplay.Name = "BtnDisplay"
        Me.BtnDisplay.Size = New System.Drawing.Size(120, 41)
        Me.BtnDisplay.TabIndex = 10
        Me.BtnDisplay.Text = "Display"
        Me.BtnDisplay.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.IndianRed
        Me.BtnSave.ForeColor = System.Drawing.Color.Snow
        Me.BtnSave.Location = New System.Drawing.Point(36, 407)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(120, 41)
        Me.BtnSave.TabIndex = 11
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.IndianRed
        Me.Button2.ForeColor = System.Drawing.Color.Snow
        Me.Button2.Location = New System.Drawing.Point(376, 406)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 41)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "DownLoad "
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(523, 519)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnDisplay)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CourseRmNum)
        Me.Controls.Add(Me.CourseUnits)
        Me.Controls.Add(Me.CourseNam)
        Me.Controls.Add(Me.CourseNum)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents CourseNum As TextBox
    Friend WithEvents CourseNam As TextBox
    Friend WithEvents CourseUnits As TextBox
    Friend WithEvents CourseRmNum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnDisplay As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
